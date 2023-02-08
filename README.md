# Contact Detail List - Code Challenge

I suggest bookmarking this page to come back while you are installing the proper software.

💾 Software Requirements 💾
- <a href="https://visualstudio.microsoft.com/downloads/">Visual Studio 2022 Pro or Community</a>
- <a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads">SQL Express</a>

🚀 Software Installation Guide 🚀

### Visual Studio
1. To install Visual Studio 2022 click and follow the link above to their download page. 
2. Choose your preffered version to install; VS22 Community is free to use.
![image](https://user-images.githubusercontent.com/31110844/217431081-56bc97fa-cbde-4698-808e-732ad71f583e.png)

3. Open and execute the VisualStudioSetup.exe and follow the installation instructions for Community.
    1. Make sure under the "Workloads" tab that you install the following:
       - ASP.NET and web development
       - .NET desktop development
    ![image](https://user-images.githubusercontent.com/31110844/217429808-f9ba3931-f689-4004-a143-ae5ddcd8706b.png)
       - Data storage and processing
    ![image](https://user-images.githubusercontent.com/31110844/217429858-60245288-9712-4467-bd6e-9fd4fb44a5ff.png)

    2. Your Installation Details on the right of your screen should match the picture below:
    ![image](https://user-images.githubusercontent.com/31110844/217429758-dcb9219d-4a88-4fd3-b10b-93599f137c47.png)

3. Click Install and wait until your installation completes.
4. Open your Visual Studio IDE.
5. A box should open with an Open Recent header, Search box, and on the right a "Getting Started" column.
6. Under the "Getting Started" column click "Clone a repository".
![image](https://user-images.githubusercontent.com/31110844/217430127-4f743482-7025-4893-a73f-fa0105594aeb.png)

7. You will be redirected to a new screen where you will see a "Repository Location" text box.
8. Enter "https://github.com/Kuscko/CodeChallenge.git" into this text box.
9. Choose where you would like to clone this Git repository in the Path text box by clicking the Button with 3 dots in it.
10. Click the "Clone" button in the bottom right corner.
![image](https://user-images.githubusercontent.com/31110844/217430468-c4359cf2-051d-4907-bb01-5b0c3982f3ff.png)


### SQL Express
1. To Install SQL Express click and follow the link above to their download page.
2. Scroll down and click the "Download Now" button under "Express" on the right side of the screen.
![image](https://user-images.githubusercontent.com/31110844/217428459-dfe1c19a-c532-4142-9627-e9aeff62b660.png)

3. Open and execute the SQL2022-SSEI-Expr.exe and choose the "Basic" option on the left.
![image](https://user-images.githubusercontent.com/31110844/217428804-8282b4e6-3c6c-429c-9d4b-a26a3a93b124.png)

4. Read and accept the Microsoft SQL Server License Terms.
![image](https://user-images.githubusercontent.com/31110844/217428996-c51a8c6b-4b68-4bc5-b3a5-130c1c0b3323.png)

5. Click the Install Button.
![image](https://user-images.githubusercontent.com/31110844/217429221-743c95df-2948-444f-9bd6-224f4cdb0014.png)

6. After your installation is succesfully installed You will see a "Connection String" Box.
   - Copy this connection string by clicking the button to the right of the box.
   - Save this connection string you will need it to configure your connection string for the Code Challenge. 
   - It should match the connection string here "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"
   ![image](https://user-images.githubusercontent.com/31110844/217429989-3db78b8d-4f2f-441d-a208-3cbf08950f9c.png)

7. Close the intaller. 

### Configuring the Project
1. In the Solution Explorer Right Click the "CodingChallenge.Presentation" and Click "Set as Startup Project"
![image](https://user-images.githubusercontent.com/31110844/217430765-d08a4c86-5a06-4e43-8bcf-6a440375a72c.png)

2. Open "CodingChallenge.Presentation" and navigate to and open "appsettings.json".
3. On Line 3 change the existing "DefaultConnection" and paste the connection string you copied earlier. 
4. Due to no existing trusted CA Certificate registered, we're going to append "Encrypte=False;" to the end of the connection string instead since this will be running locally and not exposed. 
   - Your connection string should now look something like this: "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=False;"
![image](https://user-images.githubusercontent.com/31110844/217430968-eafd1db8-9330-42d3-b0fe-4f5e0d89c8a8.png)

5. Save your changes and Build the solution by the following methods:
   - Visual Studio Hotkeys: Ctrl+Shift+B
   - Clicking the Build Menu option in the top of Visual Studio, then clicking "Build Solution"
5. Now Run the application by Clicking the Box with the green arrow and the name "CodeChallenge.Presentation".
![image](https://user-images.githubusercontent.com/31110844/217419819-101e804f-53fb-4388-8026-e79d951ee5b2.png)

