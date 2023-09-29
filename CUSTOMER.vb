Imports Devart.Data.MySql
'Imports MySql.Data.MySqlClient
Public Class CUSTOMER
    'Create a function to insert a new customer
    Dim connection As New MySqlConnection("data source=localhost;port=3306;User Id=root;password=mwendiabae;database=test")

    Function Add_Customer() As Boolean

    End Function
    Dim command As New MySqlCommand("INSERT INTO `Customer`Customer (`customerid`, `firstname`, `middlenmae`, `lastname`, `email`, `street`, `city`, `state`, `zip`, `phonenumber`, `activeyn`) VALUES (@fname,@mname,@lname,@eml,@str, @cty, @stt, @zp, @pno,@activ)", connection)
End Class
