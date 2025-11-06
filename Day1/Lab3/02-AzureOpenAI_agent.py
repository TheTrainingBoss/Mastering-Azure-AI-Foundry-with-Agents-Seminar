import asyncio
import os
from dotenv import load_dotenv
from semantic_kernel.agents import ChatCompletionAgent
from semantic_kernel.connectors.ai.open_ai import AzureChatCompletion
from semantic_kernel.functions import kernel_function

async def main():

    model_id = "gpt-4.1"
    api_key = "replace"
    endpoint = "replace"

    agent = ChatCompletionAgent(
        service=AzureChatCompletion(
            deployment_name=model_id, 
            api_key=api_key, 
            endpoint=endpoint),
        name="chat_agent",
        instructions="You are a helpful assistant."
    )
    response = await agent.get_response("Why is the sky blue?")
    print(response)


if __name__ == "__main__":
    asyncio.run(main())

