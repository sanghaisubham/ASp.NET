<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="canvas.aspx.cs" Inherits="HTML5Examples.Drawing.canvas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <canvas id="canvas" height="500" width="500"> </canvas>
    </form>

    <script>
   /* function draw()
        {
            var canvas = document.getElementById('canvas');
            var context = canvas.getContext('2d');
           context.rect(10, 10, 200, 150);
            context.fillStyle = 'red';
            context.strokeStyle = 'blue';
            context.lineWidth = '10';
            context.stroke();
            context.fill();
   
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            context.moveTo(50, 50);
            context.strokeStyle = 'orange';
            context.lineWidth = '20';
            context.lineTo(200, 200);
            context.lineCap = 'round';
            context.stroke();
            context.beginPath();
            context.moveTo(200, 200);
            context.strokeStyle = 'blue';
            context.lineTo(400, 300);
            context.stroke();
           
        }
        */
    /*  function draw()
        {
            var canvas = document.getElementById('canvas');
            var context = canvas.getContext('2d');
            context.strokeStyle = 'red';
            context.lineWidth = 4;
            context.fillStyle = "yellow";
            context.font = "70px consolas";
            context.strokeText("Hello world", 50, 100);
            context.fillText("Hello world", 50, 100);

            context.strokeText("Hi", 50, 150);
            context.fillText("Hi", 50, 150);
          
        }*/

        function draw()
        {
            var canvas = document.getElementById('canvas');
            var context = canvas.getContext('2d');
/*          var lg = context.createLinearGradient(200,200,0,0);
            lg.addColorStop(0, 'green');
            lg.addColorStop(.5, 'white');
            lg.addColorStop(1, 'blue');
            context.fillStyle = lg;
            context.fillRect(0, 0, 200, 200);
  */
            var lg = context.createRadialGradient(100, 100, 90, 70, 100, 0);
            lg.addColorStop(0, 'black');
            lg.addColorStop(1,'white');
            
            context.fillStyle = lg;
            context.lineWidth = 3;
            context.arc(100, 100, 90, 0, 2 * Math.PI);
            context.fill();
            context.stroke();
  }

        draw();
    </script>
</body>
</html>
