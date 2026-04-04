# Azure Trusted Signing Setup

```bash
# 1. Create service principal
az ad sp create-for-rbac --name "github-codesigning" --output json
# outputs: appId (client ID), password (client secret), tenant (tenant ID)

# 2. Assign signing role (scope must go to certificate profile level)
# Note: correct role name is "Artifact Signing Certificate Profile Signer"
az role assignment create \
  --assignee <appId> \
  --role "Artifact Signing Certificate Profile Signer" \
  --scope "/subscriptions/<subscription-id>/resourceGroups/xldent/providers/Microsoft.CodeSigning/codeSigningAccounts/xldent-account/certificateProfiles/hesamian"

# 3. Get the signing endpoint
az resource show \
  --ids "/subscriptions/<subscription-id>/resourceGroups/xldent/providers/Microsoft.CodeSigning/codeSigningAccounts/xldent-account" \
  --query "properties.accountUri" -o tsv
```
