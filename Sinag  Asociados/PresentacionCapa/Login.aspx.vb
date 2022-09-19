Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtusername.Text == "jaja" && txtpass.Text == "123") Then
          {   
            Response.Redirect("inicio.aspx")

          }
            Else
            {
            MensajeError.Text = "la cago";

            }



    End Sub
End Class