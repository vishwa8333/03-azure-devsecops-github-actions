# Azure DevSecOps Pipeline with GitHub Actions

## Goal

Create a secure CI/CD pipeline that builds, scans, tests, signs, and deploys a containerized application to Azure.

## Azure Services

- Azure Container Registry
- Azure Kubernetes Service or Azure Container Apps
- Azure Key Vault
- Microsoft Defender for Cloud
- Azure Monitor

## DevOps Skills Demonstrated

- GitHub Actions pipelines
- Docker build and push
- SAST and dependency scanning
- Container image vulnerability scanning
- Secret-free authentication using OIDC
- Deployment approvals and environments

## Suggested Structure

```text
app/
infra/
security/
.github/workflows/
```

## Pipeline Stages

```text
lint -> test -> security scan -> build image -> push image -> deploy -> smoke test
```

