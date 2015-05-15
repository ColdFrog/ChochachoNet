<%@ Page Language="C#" AutoEventWireup="false" Inherits="Chochachonet.AnagraphTester" ValidateRequest="false" EnableSessionState="false"  MasterPageFile="~/page.master"  %>

<asp:Content ID="Content0" ContentPlaceHolderID="HeaderContent" Runat="Server">
	<script type="text/javascript">
		function setAction() {
			Form1.onsubmit = function() { alert("X"); return true; };
		}
		$(document).ready();
	</script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
	<div style="text-align:center;">
		<div style="padding-top:5px; padding-bottom:5px;">
			<asp:TextBox id="word1" runat="server" />&nbsp;&nbsp;<asp:TextBox id="word2" runat="server" />
		</div>
		<div style="padding-bottom:5px;">
			<asp:Button id="compareButton" Text="Are They Anagraphs?" OnClick="CompareWords" runat="server" />
		</div>
		<div Visible="False" style="margin: 0 auto; margin-bottom:5px; width:500px; border:1px solid red; color:red;" id="ErrorBox" runat="server">
			You can only compare letters. Sucks.
		</div>
		<div Visible="False" style="margin: 0 auto; max-height:500px; width:800px; border:1px solid black; overflow:auto;" id="ResultBox" runat="server">
			<asp:Label id="WordCompareBox" runat="server" Text="" />
		</div>
	</div>
</asp:Content>