<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AngularJS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/angularjs/1.2.15/angular.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <script type="text/javascript">
            function Simplecontroller($scope) {
                $scope.Customers = [
                    { name: '', city: '' },
                     { name: '', city: '' },
                      { name: '', city: '' },
                       { name: '', city: '' }
                ]
            }
        </script>


        <p>Input something in the input box:</p>


        <%--  <p>Total in dollar: {{ quantity * cost }}</p>
    <asp:Label ID="Label1" runat="server" Text="Label" ng-bind="name"></asp:Label>
    <input  type="text" ng-bind="{{5*5 }}" />
    <p>{{5+5}}</p>


    </div>
        <div ng-app="">
            <input  type="text" ng-model="lastname" value="sompalli"/>
          <asp:Label ID="Label" runat="server" Text="Label" ng-bind="lastname"></asp:Label>
        </div>
        --%>
        <div data-ng-controller="Simplecontroller">
            <p>Name:
                <input type="text" ng-model="name" value="John" /></p>
            <br />
            <ul>
                <li data-ng-repeat="cust in Customers |filter:name|orederbbby:name"></li>

            </ul>
        </div>

    </form>
</body>
</html>
