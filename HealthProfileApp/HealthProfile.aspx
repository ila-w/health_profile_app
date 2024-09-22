<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HealthProfile.aspx.cs" Inherits="HealthProfileApp.HealthProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Health Profile Application</title>    
    
</head>
<body>
    <h2>Patient Information</h2>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <form method="post" action="PatientReport.aspx">
        &nbsp;&nbsp; First Name: <input type="text" name="fname"/>
        &nbsp;&nbsp; Last Name: <input type="text" name="lname"/> <br/>
        &nbsp;Birth Month: <input type="text" name="month"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Gender: <input type="text" name="gender"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <input type="submit" value="Calculate BMI"/><br/>
        &nbsp;&nbsp;&nbsp;&nbsp; 
        Birth Day: <input type="text" name="day"/>&nbsp;&nbsp;
        Height (in): <input type="text" name="height"/> <br/>
        &nbsp;&nbsp;&nbsp; Birth Year: <input type="text" name="year"/>&nbsp;Weight (lbs): <input type="text" name="weight"/> 
    </form>

    <br/>

    <table class="chart" id="bmitable" hidden="hidden">
        <tr>
            <th>BMI Categories</th>
        </tr>
        <tr>
            <td>Underweight: < 18.5</td>
        </tr>
        <tr>
            <td>Normal weight: 18.5 to 24.9</td>
        </tr>
        <tr>
            <td>Overweight: 25 to 29.9</td>
        </tr>
        <tr>
            <td>Obese: 30+</td>
        </tr>
    </table>

    <br/>

    <button onclick="toggle(this);">Show me the BMI Chart</button>

    <script>
        let toggle = clicked => {
            let chart = document.getElementById("bmitable");
            let invisible = chart.getAttribute("hidden");

            if (invisible) {
                chart.removeAttribute("hidden");
                clicked.innerText = "Hide the BMI Chart";
            } else {
                chart.setAttribute("hidden", "hidden");
                clicked.innerText = "Show me the BMI Chart";
            }
        }
    </script>

</body>
</html>
