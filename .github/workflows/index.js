
const core = require('@actions/core');
const github = require('@actions/github');
const http = require('@actions/http-client');

function createPayload(teamID, jobID, subID, status, duration, buildName, buildUrl, applicationName){
  const payload = {
    "event": true,
    "name": "build",
    "r1.team.id": teamID,
    "job.id": jobID,
    "job.sub_id": subID,
    "job.result": status,
    "job.duration": duration,
    "job.name": buildName,
    "job.url": buildUrl,
    "application.name": applicationName,
    "type": "devops_metrics"
  };

  return payload;
}

function sendRequest(url, payload) {
  let client = new http.HttpClient();
  (async () => {
    var response = await client.postJson(url, payload);
    console.log(`Status: ${response.statusCode}`)
    console.log(`Response: ${response.content}`)
  })();
}

try {
  // See the payload dumped to the console for available properties
  // console.log(`Available context: ${github.context}`)
  const otelToken = core.getInput('otel-token');
  const teamID = core.getInput('team-id');
  const status = core.getInput('build-status');
  const relEyeURL = `https://services.ctus.reg.k8s.r1.kcura.com/maas/webhook/generic/v1?token=${otelToken}`;
  const buildName = `${github.context.payload.repository.full_name}`
  const buildUrl = `${github.context.payload.repository.svn_url}/runs/${github.context.runId}/attempts/${github.context.runNumber}`
  const applicationName = github.context.payload.repository.name

  // TODO: If we can run unit tests against the functions in here, this might be valuable to turn into a function.
  const startTime = new Date(github.context.payload.head_commit.timestamp);
  const endTime = new Date();
  const duration = parseInt((endTime - startTime)/1000);

  const payload = createPayload(teamID, github.run_id, github.run_attempt, status, duration, buildName, buildUrl, applicationName);

  console.log(`Sending build event with the following payload: ${JSON.stringify(payload)}`);
  sendRequest(relEyeURL, payload);
} catch (error) {
  core.setFailed(error.message);
}