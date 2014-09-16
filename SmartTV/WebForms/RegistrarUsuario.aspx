<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrarUsuario.aspx.cs" Inherits="RegistrarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/jumbotron.css" rel="stylesheet" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.1/themes/smoothness/jquery-ui.css">
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.1/jquery-ui.js"></script>
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script>
        $(function () {
            $("#txtFecNacimiento").datepicker();
        });
    </script>
    <script type="text/javascript">
        function ValidarLength(oSrc, args) {
            args.IsValid = (args.Value.length >= 8 && args.Value.length <= 16);
        }
        function ValidarLengthUser(oSrc, args) {
            args.IsValid = (args.Value.length >= 1 && args.Value.length <= 16);
        }
      
             function MsgError(mensaje) {
            $(function () {
                $("#dialog").html(mensaje);
                $("#dialog").dialog({
                    title: "Mensaje Error",
                    buttons: {
                        Aceptar: function () {
                                $(this).dialog('close'); 
                        }
                    },
                    modal: true
                });
            });
             };
    </script>
    <script>
        function MsgConfirmacion(mensaje) {
             $(function () {
                $("#dialog").html(mensaje);
                $("#dialog").dialog({
                    title: "Mensaje de confirmacion",
                    buttons: {
                        Aceptar: function () {
                                $(this).dialog('close'); window.location.href = "index.aspx";
                        }
                    },
                    modal: true
                });
            });
        };
        </script>
    <h2>Registro Nuevo Usuario</h2>

</head>
<body>
    <div id="dialog" style="display: none">
    </div>
    <div class="page-header">
        <div class="row">
            <div class="col-md-10">
                <form id="frmIndex" runat="server">

                    <div class="form-group">
                        <label>Usuario</label>
                        <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtUsuario" runat="server" ControlToValidate="txtUsuario" Display="Dynamic" ErrorMessage="Debe ingresar un Usuario" />
                        <asp:CustomValidator ID="cvtxtUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="El nombre debe ser menor a 16 caracteres" OnServerValidate="cvtxtUsuario_ServerValidate" ClientValidationFunction="ValidarLengthUser" />
                    </div>

                    <div class="form-group">
                        <label>Contraseña</label>
                        <asp:TextBox ID="txtContrasena" TextMode="Password" CssClass="form-control" Font-Size="Larger" runat="server"></asp:TextBox>
                        <asp:CustomValidator ID="ContrasenaValidator" runat="server" ControlToValidate="txtContrasena" ErrorMessage="La contraseña debe tener entre 8  y 16 caracteres" OnServerValidate="ContrasenaValidator_ServerValidate" ClientValidationFunction="ValidarLength" />
                        <asp:RequiredFieldValidator ID="rfvtxtContrasena" runat="server" ControlToValidate="txtContrasena" Display="Dynamic" ErrorMessage="Debe ingresar una contraseña"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <label>Nombre</label>
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rdvNombre" runat="server" ControlToValidate="txtNombre" Display="Dynamic" ErrorMessage="Debe ingresar su nombre" />
                    </div>

                    <div class="form-group">
                        <label>Fecha de Nacimiento</label>
                        <asp:TextBox ID="txtFecNacimiento" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFecNacimiento" Display="Dynamic" ErrorMessage="Debe ingresar su fecha de nacimiento" />
                    </div>

                    <div class="form-group">
                        <label>Correo</label>
                        <asp:TextBox ID="txtCorreo" CssClass="form-control" placeholder="isaacmoreano@hotmail.com" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtCorreo" runat="server" ControlToValidate="txtCorreo" Display="Dynamic" ErrorMessage="Debe ingresar un correo" />
                        <asp:RegularExpressionValidator ID="revtxtCorreo" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtCorreo" ErrorMessage="Correo no tiene le formato correcto"></asp:RegularExpressionValidator>


                    </div>

                    <div style="text-align: right">
                        <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary" Text="Registrar" OnClick="btnLogin_Click" CausesValidation="true" />
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Text="Cancelar" CausesValidation="false" />

                    </div>

                </form>
            </div>
        </div>
    </div>
</body>
</html>
