const { exec } = require("child_process");

// Define the command to run .NET tests
const command = "dotnet test NodejsTest";

// Execute the command
exec(command, (err, stdout, stderr) => {
    if (err) {
        console.error("Error running tests:", stderr);
        return;
    }
    console.log("C# Test Results:\n", stdout);
});