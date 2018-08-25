<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Beatmaker.aspx.cs" Inherits="Beatmaker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>


    

            <script type="text/javascript" src="JavaScript.js"></script>
            <script type="text/javascript">
                function stopTimer() {
                    var timer = Sys.Application.findComponent('<%= Timer1.ClientID %>');
                    timer._stopTimer();
                }
                function startTimer() {
                    var timer = Sys.Application.findComponent('<%= Timer1.ClientID %>');
                     timer._startTimer();
                 }
            </script>

            <style>
                .button {
                    position: relative;
                    border-radius: 8px;
                    background-color: #555555;
                    border: none;
                    font-size: 12px;
                    color: white;
                    padding: 10px;
                    width: 50px;
                    height: 50px;
                    text-align: center;
                    -webkit-transition-duration: 0.4s; /* Safari */
                    transition-duration: 0.4s;
                    text-decoration: none;
                    overflow: hidden;
                    cursor: pointer;
                }

                .btnBeat {
                    padding: 10px;
                    padding-left: 5px;
                    text-align: center;
                    text-decoration: solid;
                    font-family: Rockwell;
                    margin: 8px;
                    border: ridge;
                    border-radius: 10px;
                    width: 25px;
                    height: 35px;
                    background-color: rgba(128, 128, 128, 0.5);
                    color: black;
                }
            </style>

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

                <span style="font-size: 30px; cursor: pointer;" onclick="toggleNav()">&#9776;  
                     &nbsp;&nbsp;&nbsp;
                <label class="switch" style="vertical-align:central"> 
                  <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Checked="true" />
                  <div class="slider round"></div>
                </label> <font style="vertical-align:5px" face="Papyrus" color="gray" size="3px">Beatmaker</font>
                </span>

                <div id="dropdown" runat="server" style="float: right;">
                    <asp:Button Style="width: 30px; height: 30px; font-size: 10px;" CssClass="btnRec" ID="BtnRecMain" runat="server" Text="Rec" OnClick="BtnRecMain_Click" />
                    <div class="dropdown-content" style="z-index:11; background-color:rgba(0,0,0,0.8)">
                        <a href="Mail.aspx">Share!</a>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Download!</asp:LinkButton>
                    </div>
                </div>

                <br />
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
                <div runat="server" id="tableBtns"><br />
                    <table align="center" cellspacing="10" cellpadding="0">
                        <tr>
                            <td>
                                <asp:Button ID="ButtonQ" runat="server" CssClass="button" Text="Q" OnClientClick="PlaySound('Q.wav')" OnClick="Button1_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonW" runat="server" CssClass="button" Text="W" OnClientClick="PlaySound('W.wav')" OnClick="ButtonW_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonE" runat="server" CssClass="button" Text="E" OnClientClick="PlaySound('E.wav')" OnClick="ButtonE_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonR" runat="server" CssClass="button" Text="R" OnClientClick="PlaySound('R.wav')" OnClick="ButtonR_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonT" runat="server" CssClass="button" Text="T" OnClientClick="PlaySound('T.wav')" OnClick="ButtonT_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonY" runat="server" CssClass="button" Text="Y" OnClientClick="PlaySound('Y.wav')" OnClick="ButtonY_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonU" runat="server" CssClass="button" Text="U" OnClientClick="PlaySound('U.wav')" OnClick="ButtonU_Click" /></td>

                            <td>
                                <asp:Button ID="ButtonA" runat="server" CssClass="button" Text="A" OnClientClick="PlaySound('A.wav')" OnClick="ButtonA_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonS" runat="server" CssClass="button" Text="S" OnClientClick="PlaySound('S.wav')" OnClick="ButtonS_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonD" runat="server" CssClass="button" Text="D" OnClientClick="PlaySound('D.wav')" OnClick="ButtonD_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonF" runat="server" CssClass="button" Text="F" OnClientClick="PlaySound('F.wav')" OnClick="ButtonF_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonG" runat="server" CssClass="button" Text="G" OnClientClick="PlaySound('G.wav')" OnClick="ButtonG_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonH" runat="server" CssClass="button" Text="H" OnClientClick="PlaySound('H.wav')" OnClick="ButtonH_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonJ" runat="server" CssClass="button" Text="J" OnClientClick="PlaySound('J.wav')" OnClick="ButtonJ_Click" /></td>

                            <td>
                                <asp:Button ID="ButtonZ" runat="server" CssClass="button" Text="Z" OnClientClick="PlaySound('Z.wav')" OnClick="ButtonZ_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonX" runat="server" CssClass="button" Text="X" OnClientClick="PlaySound('X.wav')" OnClick="ButtonX_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonC" runat="server" CssClass="button" Text="C" OnClientClick="PlaySound('C.wav')" OnClick="ButtonC_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonV" runat="server" CssClass="button" Text="V" OnClientClick="PlaySound('V.wav')" OnClick="ButtonV_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonB" runat="server" CssClass="button" Text="B" OnClientClick="PlaySound('B.wav')" OnClick="ButtonB_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonN" runat="server" CssClass="button" Text="N" OnClientClick="PlaySound('N.wav')" OnClick="ButtonN_Click" /></td>
                            <td>
                                <asp:Button ID="ButtonM" runat="server" CssClass="button" Text="M" OnClientClick="PlaySound('M.wav')" OnClick="ButtonM_Click" /></td>
                    </table>
                </div>

                <br>
                <br>
                <div style="margin-left: 28px; margin-right: 25px; text-align: center; background-color: rgba(0,0,0,0.3); display: block; border-radius: 15px">
                    
                     <div id="Div1" class="dropdownBpm" runat="server">
                        <asp:Button onmouseover="stopTimer();" Style="padding: 10px; background-color: rgba(0,0,0,0); color: black; font-size: 20px; font-family: Rockwell; border: none" CssClass="btnBpm" ID="Button1" runat="server" Text="COUNT" />
                        <div class="dropdownBpm-content" style="left: 0; width: 150px;">
                            <asp:DropDownList AutoPostBack="True" ID="DropDownList2" runat="server" CssClass="styled-select" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>30</asp:ListItem>
                                <asp:ListItem>45</asp:ListItem>
                                <asp:ListItem>60</asp:ListItem>
                                <asp:ListItem>75</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    
                    <asp:Button OnClientClick="startTimer()" Style="font-family: Rockwell; background-color: rgba(0,0,0,0); border: none; font-size: 20px; padding: 10px;" ID="play" runat="server" Text="PLAY" OnClick="play_Click" />
                    <asp:Button OnClientClick="stopTimer()" Style="font-family: Rockwell; background-color: rgba(0,0,0,0); border: none; font-size: 20px; padding: 10px;" ID="pause" runat="server" Text="PAUSE" OnClick="pause_Click" />

                    <div class="dropdownBpm" runat="server">
                        <asp:Button onmouseover="stopTimer();" Style="padding: 10px; background-color: rgba(0,0,0,0); color: black; font-size: 20px; font-family: Rockwell; border: none" CssClass="btnBpm" ID="Button22" runat="server" Text="BPM" />
                        <div class="dropdownBpm-content" style="left: 0; width: 150px;">
                            <asp:TextBox Style="color: white" ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Text="500"></asp:TextBox>
                            <asp:Label Style="color: white" ID="Label1" runat="server" Text="Label"></asp:Label>
                            <ajaxToolkit:SliderExtender ID="SliderExtender1" runat="server" TargetControlID="TextBox1" BoundControlID="Label1" EnableHandleAnimation="true" Minimum="20" Maximum="1000" Steps="100" TooltipText="Move Slider" Orientation="Horizontal" RailCssClass="ajax__slider_h_rail" HandleCssClass="ajax__slider_h_handle" />
                        </div>
                    </div>


                </div>
                <br />

                <div id="DivBeatmaker" runat="server" style="margin-left: 28px; margin-right: 25px; text-align: center; min-height: 300px; background-color: rgba(0,0,0,0.4); display: block; border-radius: 15px">
                    <br>
                </div>
            </div>


            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="500" Enabled="False">
            </asp:Timer>

        </ContentTemplate>


    </asp:UpdatePanel>




</asp:Content>

