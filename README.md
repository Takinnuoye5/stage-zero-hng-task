# 🚀 HNG STAGE ZERO TASK - Public API  

## 📌 Project Overview  
This project is a simple **public API** built using **ASP.NET Core** that returns basic information in JSON format, including:  
- 📧 **Your registered email address**  
- ⏰ **The current date and time (ISO 8601 format, UTC)**  
- 🔗 **The GitHub URL of the project codebase**  

It follows **RESTful API** best practices and is publicly accessible.

---

## 🌍 API Specification  

### **🛠 Endpoint**  
#### `GET /RetrieveBasicInformation`  
Returns a **JSON response** with the following details.  

### **✅ Response Format (200 OK)**  
```json
{
  "email": "akinnuoyet@gmail.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/Takinnuoye5/stage-zero-hng-task"
}


## Additional Links
HNG HireHire csharp Developer | https://hng.tech/hire/csharp-developers



🏗 Technology Stack
Language: C#
Framework: ASP.NET Core
Hosting: Azure / Any Cloud Platform
Version Control: GitHub



🖥 Setup Instructions (Run Locally)
📌 Prerequisites
Ensure you have the following installed:

🔹 Visual Studio
🔹 .NET SDK



📂 Clone the Repository

```bash

git clone https://github.com/Takinnuoye5/stage-zero-hng-task
cd your-repo


🚀 Run the API Locally
```bash

dotnet restore
dotnet run


The API should now be running at:

🌐 http://localhost:5000/RetrieveBasicInformation
🔒 https://localhost:7244/RetrieveBasicInformation (Your Local HTTPS Link)



🌐 Deployment
The API is deployed to a publicly accessible endpoint.

📌 Live API URL:
🔗 https://your-app.azurewebsites.net/RetrieveBasicInformation

🚀 Deploy to Azure
To deploy on Azure, follow these steps:

Open Visual Studio and right-click the project.
Select "Publish", choose Azure App Service, and configure deployment settings.
Click Publish and wait for deployment to complete.


🔍 Testing the API
🌐 Using a Browser
Visit:
🔗 https://your-app.azurewebsites.net/RetrieveBasicInformation

📬 Using Postman
Send a GET request to the endpoint.
💻 Using cURL
```bash

curl -X GET "https://your-app.azurewebsites.net/RetrieveBasicInformation" -H "Accept: application/json"
📜 Documentation

📄 API Documentation Includes:
✅ Endpoint URL
✅ Request/Response Format
✅ Example Usage



🔗 Repository Details
📂 GitHub Repository: https://github.com/Takinnuoye5/stage-zero-hng-task
📜 README.md includes:
🔹 Project Description
🔹 Setup Instructions
🔹 API Documentation
🔹 Deployment Steps


