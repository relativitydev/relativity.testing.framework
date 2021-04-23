using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests
{
	[TestFixture]
	[TestOf(typeof(GroupPermissionsChangeset))]
	public class GroupPermissionsChangesetFixture
	{
		[Test]
		public void Execute()
		{
			// Arrange original permissions.
			GroupPermissions groupPermissions = new GroupPermissions();

			groupPermissions.ObjectPermissions.Add(
				new ObjectPermission
				{
					Name = "objperm",
					EditEditable = true,
					DeleteEditable = true,
					AddEditable = true,
					EditSecurityEditable = true,
					SubPermissions = new List<PermissionDetail>
					{
						new PermissionDetail { Name = "suba" },
						new PermissionDetail { Name = "subb" },
						new PermissionDetail { Name = "subc" }
					}
				});

			groupPermissions.TabVisibility.Add(
				new GenericPermission
				{
					Name = "tvperm",
					Editable = true,
					Selected = true
				});

			groupPermissions.BrowserPermissions.Add(
				new GenericPermission
				{
					Name = "brperm",
					Editable = true,
					Selected = false,
					Children = new List<GenericPermission>
					{
						new GenericPermission
						{
							Name = "brperm-1",
							Editable = true,
							Selected = false
						},
						new GenericPermission
						{
							Name = "brperm-1",
							Editable = false,
							Selected = false
						}
					}
				});

			// Arrange permissions changeset.
			GroupPermissionsChangeset sut = new GroupPermissionsChangeset().
				ObjectPermissions["objperm"].Set(ObjectPermissionKinds.ViewEditAdd).
				ObjectPermissions["objperm"].SubPermissions.Enable("suba", "subc").
				TabVisibility["tvperm"].Disable().
				BrowserPermissions.EnableAll();

			// Act.
			sut.Execute(groupPermissions);

			// Assert.
			var modifiedObjectPermission = groupPermissions.ObjectPermissions.First(x => x.Name == "objperm");

			using (new AssertionScope())
			{
				modifiedObjectPermission.ViewSelected.Should().BeTrue();
				modifiedObjectPermission.EditSelected.Should().BeTrue();
				modifiedObjectPermission.AddSelected.Should().BeTrue();
				modifiedObjectPermission.DeleteSelected.Should().BeFalse();
				modifiedObjectPermission.EditSecuritySelected.Should().BeFalse();

				modifiedObjectPermission.SubPermissions.Where(x => x.Selected).Select(x => x.Name).
					Should().BeEquivalentTo("suba", "subc");
			}

			var modifiedTabVisibilityPermission = groupPermissions.TabVisibility.First(x => x.Name == "tvperm");

			modifiedTabVisibilityPermission.Selected.Should().BeFalse();

			var modifiedBrowserPermission = groupPermissions.BrowserPermissions.First(x => x.Name == "brperm");

			using (new AssertionScope())
			{
				modifiedBrowserPermission.Selected.Should().BeTrue();
				modifiedBrowserPermission.Children[0].Selected.Should().BeTrue();
				modifiedBrowserPermission.Children[1].Selected.Should().BeFalse();
			}
		}
	}
}
