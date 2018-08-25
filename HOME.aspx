<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HOME.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <script type="text/javascript" src="JavaScript.js"></script>

    <div>
        <div id="mySidenav" class="sidenav">
            <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>

            <div style="text-align: center; font-family: Rockwell;">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="styled-select" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1" AutoPostBack="True">
                    <asp:ListItem align="center">Beats</asp:ListItem>
                    <asp:ListItem>Piano</asp:ListItem>
                    <asp:ListItem>Guitar</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Image Width="200px" Height="200px" ID="Image1" runat="server" ImageUrl="~/icons/Beats.png" />
            </div>
            <br />
            <hr />
            <br />
            <ul>
                <li>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx" Font-Names="Rockwell">Login</asp:HyperLink></li>
            </ul>
        </div>

        <div id="main">

            <span style="font-size: 30px; cursor: pointer" onclick="toggleNav()">&#9776;   
                &nbsp;&nbsp;&nbsp;
                <label class="switch" style="vertical-align: central">
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    <div class="slider round"></div>
                </label>
                <font style="vertical-align: 5px" face="Papyrus" color="gray" size="3px">Beatmaker</font>

            </span>

            <div id="dropdown" runat="server" style="float: right">
                <asp:Button CssClass="btnRec" ID="BtnRecMain" runat="server" Text="Rec" OnClick="BtnRecMain_Click" />
                <div class="dropdown-content">
                    <a href="Mail.aspx">Share!</a>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Download!</asp:LinkButton>
                </div>
            </div>

            <table cellspacing="0" cellpadding="2" align="center" style="padding-left: 2em">

                <tr height="140px" style="color: red">
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('Q.wav')" id="Q">Q</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('W.wav')" id="W">W</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('E.wav')" id="E">E</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('R.wav')" id="R">R</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('T.wav')" id="T">T</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('Y.wav')" id="Y">Y</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('U.wav')" id="U">U</button>&nbsp;</td>
                </tr>
                <tr height="140px">
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('A.wav')" id="A">A</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('S.wav')" id="S">S</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('D.wav')" id="D">D</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('F.wav')" id="F">F</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('G.wav')" id="G">G</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('H.wav')" id="H">H</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('J.wav')" id="J">J</button>&nbsp;</td>
                </tr>
                <tr height="140px">
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('Z.wav')" id="Z">Z</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('X.wav')" id="X">X</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('C.wav')" id="C">C</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('V.wav')" id="V">V</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('B.wav')" id="B">B</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('N.wav')" id="N">N</button>&nbsp;</td>
                    <td>&nbsp;
                        <button class="button" type="button" onclick="PlaySound('M.wav')" id="M">M</button>&nbsp;</td>
                </tr>
            </table>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <table cellspacing="4" cellpadding="2" align="center" style="padding-right: 1em">
                        <tr height="140px">
                            <!--<td>&nbsp;<button style="background-color: #008CBA;" class="button" type="button" onclick="PlaySound('1.wav')" id="1">1</button>&nbsp;</td>-->
                            <td>&nbsp;&nbsp;<asp:Button Style="background-color: indianred;" CssClass="button" ID="btn_Rec1" runat="server" Text="1" OnClick="btn_Rec1_Click" />&nbsp; </td>
                            <td>&nbsp;<asp:Button Style="background-color: indianred;" CssClass="button" ID="btn_Rec2" runat="server" Text="2" OnClick="btn_Rec2_Click" />&nbsp; </td>
                            <td>&nbsp;<asp:Button Style="background-color: indianred;" CssClass="button" ID="btn_Rec3" runat="server" Text="3" OnClick="btn_Rec3_Click" />&nbsp; </td>
                            <td>&nbsp;<asp:Button Style="background-color: indianred;" CssClass="button" ID="btn_Rec4" runat="server" Text="4" OnClick="btn_Rec4_Click" />&nbsp; </td>
                            <td>&nbsp;<asp:Button Style="background-color: indianred;" CssClass="button" ID="btn_Rec5" runat="server" Text="5" OnClick="btn_Rec5_Click" />&nbsp; </td>
                            <td>&nbsp;<asp:Button Style="background-color: indianred;" CssClass="button" ID="btn_Rec6" runat="server" Text="6" OnClick="btn_Rec6_Click" />&nbsp; </td>
                            <td>&nbsp;<asp:Button Style="background-color: indianred;" CssClass="button" ID="btn_Rec7" runat="server" Text="7" OnClick="btn_Rec7_Click" />&nbsp; </td>
                        </tr>
                    </table>

                </ContentTemplate>
            </asp:UpdatePanel>

            <div id="Visualizer">
                <canvas align="center" id="canvas" width="500" height="50"></canvas>
            </div>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    <div id="myDivTag" runat="server" align="center"></div>
                </ContentTemplate>
            </asp:UpdatePanel>


        </div>
    </div>
</asp:Content>

