## Try it from Postman

You can try using the Azure OpenAI resource from Postman by creating a new request and setting the endpoint and API key in the request headers. You can then send a request to the OpenAI API and get a response from the model.

The method is a **POST**
The endpoint is https://**name of the AZ OpenAI resource**.cognitiveservices.azure.com/openai/deployments/**Name of the Model given during creation**/chat/completions/?api-key=xxxxxxx&api-version=2024-12-01-preview

You can get the full parameters from the Azure OpenAI resource documentation.
https://learn.microsoft.com/en-us/azure/ai-services/openai/reference 

The body of the request can be as simple as something like
```json
{
    "messages": [
        {
            "role": "user",
            "content": "Where do Visual Studio Live Conferences take place?"
        }
    ],
    "max_tokens": 100
}
```