<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAdRotator.aspx.cs" Inherits="Ch7.FrmAdRotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="CtlAdRotator" runat="server" AdvertisementFile="~/FrmAdRotator.xml" Width="960px" Height="360px" />
            <asp:FileUpload ID="CtlFileUpload" runat="server" />
            <br />
            <asp:LinkButton ID="BtnUpload" runat="server" OnClick="BtnUpload_Click">파일업로드</asp:LinkButton>
            <br />
            <asp:Label ID="LblResult" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Wizard ID="Wizard1" runat="server" Width="600px" Height="200px" BorderWidth="1px" OnFinishButtonClick="Wizard1_FinishButtonClick">
                <WizardSteps>
                    <asp:WizardStep ID="WizardStep1" runat="server" Title="0. 처음" StepType="Start">
                        마법사를 시작합니다. <br />
                        0: <asp:TextBox ID="TxtStart" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep2" runat="server" Title="1. 중간" StepType="Step">
                        마법사를 중간합니다. <br />
                        1: <asp:TextBox ID="TxtMid" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep3" runat="server" Title="2. 마지막" StepType="Finish">
                        마법사를 마지막합니다. <br />
                        2: <asp:TextBox ID="TxtFinish" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep4" runat="server" Title="3. 끝" StepType="Complete">
                        마법사를 끝합니다. <br />
                        3: <asp:Label ID="LblComplete" runat="server"></asp:Label>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
            <asp:Panel ID="PnlFirst" runat="server" Height="50px" Width="200px" ScrollBars="Vertical">
                안녕하세요<br />
                안녕하세요<br />
                안녕하세요<br />
                안녕하세요<br />
            </asp:Panel>
            <br />
            <asp:Panel ID="PnlSecond" runat="server" Height="50px" Width="200px" GroupingText="그룹 상자">
                반갑습니다<br />
                반갑습니다<br />
            </asp:Panel>
            <br />
            <hr />
            <asp:Panel ID="PnlCommand" runat="server" Height="50px" Width="360px" DefaultButton="BtnShowPanel2">
                <asp:Button ID="BtnShowPanel1" runat="server" Text="첫번째 패널 보이기" OnClick="BtnShowPanel1_Click" />
                <asp:Button ID="BtnShowPanel2" runat="server" Text="두번째 패널 보이기" OnClick="BtnShowPanel2_Click" />
                <br />
                <asp:TextBox ID="TxtMessage" runat="server" Width="344px">여기에서 엔터키를 누르면 버튼이 클릭됩니다.</asp:TextBox>
            </asp:Panel>
            <asp:PlaceHolder ID="CtlPlaceHolder" runat="server"></asp:PlaceHolder>
            <hr />
            <asp:Label ID="LblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
