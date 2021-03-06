﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <style>
       .h1_Style{           
           text-align: center;
           font-family:Papyrus;
           color: darkslategray;
           font-size: 35px;
       }

       .txtField {
            border-radius: 5px;
            border: 1px solid #ccc;
            width: 275px;
            background-color: rgba(255,255,255,0.5);
            border: 2px solid CadetBlue;
            -webkit-transition: all .5s ease;
            -moz-transition: all .5s ease;
            transition: all .5s ease;
            border-radius: 3px;
		    padding: 10px 5px;
		    margin: 0 auto 5px auto;
		    display: block;
		    text-align: center;
            font-family:Rockwell;
		    font-size: 18px;
		    color: darkslategray;
        }
        .txtField:focus {
            width: 305px;
            background-color: white;
        }

        .btn_Style{
		    border: 2px solid CadetBlue;
           outline: 0;
           background-color: aliceblue;
		    padding: 10px 5px;
		    color: darkslategray;
		    border-radius: 3px;
		    width: 290px;
		    cursor: pointer;
		    font-family:Rockwell;
		    font-size: 18px;
		    color: darkslategray;
		    transition-duration: 0.25s;
        }

        .hlink {
           color:darkslategray; 
           text-decoration : underline;
       }
   </style>


        <h1 class="h1_Style">Welcome</h1>
        <div style="text-align: center">
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="txtField" placeholder="E-mail Address..." TextMode="Email"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="txtField" placeholder="Password..." TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn_Style" OnClick="Button1_Click"/>
            <br />
            <asp:HyperLink CssClass="hlink" ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx" Font-Size="Small" Font-Names="Rockwell Condensed">Don't have a account? Sign up here.</asp:HyperLink>
            <br /><br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Rockwell Condensed" Font-Size="15px" ForeColor="#990000"></asp:Label>
        </div>


</asp:Content>

