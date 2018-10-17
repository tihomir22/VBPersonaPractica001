Public Class Persona
    Private nombre As String
    Private edad As Integer
    Private dni As String
    Private sexo As Char
    Private peso As Double
    Private altura As Double

    Public Sub New(nombre As String, edad As Integer, peso As Double, altura As Double)
        Me.nombre = nombre
        Me.edad = edad
        Me.dni = "X5514136R"
        Me.sexo = "H"
        Me.peso = peso
        Me.altura = altura
        Me.comprobarSexo(Me.sexo)
    End Sub

    Public Sub New(nombre As String, edad As Integer, sexo As Char, dni As String, peso As Double, altura As Double)
        Me.nombre = nombre
        Me.edad = edad
        Me.dni = dni
        Me.sexo = sexo
        Me.peso = peso
        Me.altura = altura
        Me.comprobarSexo(Me.sexo)
    End Sub

    Public Sub New()
        Me.dni = "X5514136R"
        Me.sexo = "H"
    End Sub

    Public Sub New(nombre As String, edad As Integer, sexo As Char, peso As Double, altura As Double)
        Me.nombre = nombre
        Me.edad = edad
        Me.sexo = sexo
        Me.peso = peso
        Me.dni = "X5514136R"
        Me.altura = altura
        Me.comprobarSexo(Me.sexo)
    End Sub

    Public Sub New(nombre As String, edad As Integer, sexo As Char)
        Me.nombre = nombre
        Me.edad = edad
        Me.sexo = sexo
        Me.dni = "X5514136R"
        Me.altura = 0
        Me.peso = 0
        Me.comprobarSexo(Me.sexo)
    End Sub

    Function getNombre()
        Return Me.nombre
    End Function

    Function getEdad()
        Return Me.edad
    End Function

    Function getDni()
        Return Me.dni
    End Function

    Function getSexo()
        Return Me.sexo
    End Function

    Function getPeso()
        Return Me.peso
    End Function

    Function getAltura()
        Return Me.altura
    End Function

    Function setNombre(val As String)
        Me.nombre = val
    End Function

    Function setEdad(val As Integer)
        Me.edad = val
    End Function

    Function setDni(val As String)
        Me.dni = val
    End Function

    Function setSexo(val As Char)
        Me.sexo = val
    End Function

    Function setPeso(val As Double)
        Me.peso = val
    End Function

    Function setAltura(val As Double)
        Me.altura = val
    End Function

    Function toString()
        Return Me.nombre.ToString + " " + Me.edad.ToString + " " + Me.dni.ToString + " " + Me.sexo.ToString + " " + Me.peso.ToString + " " + Me.altura.ToString

    End Function

    Function calcularIMC()
        Dim resultado As Double = (Me.peso / (Me.altura ^ 2))
        Console.WriteLine("El resultado es del IMC " + resultado.ToString)
        If (resultado < 20) Then
            Return -1
        ElseIf (resultado > 19 And resultado < 26) Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Function esMayorDeEdad()
        Dim edad As Integer = Me.edad

        If (edad > 17) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function comprobarSexo(c As Char)
        Dim sexoIntroducido As Char = Me.sexo
        If (sexoIntroducido <> "H" And sexoIntroducido <> "M") Then
            Me.setSexo("H")
        Else
            Console.WriteLine("El sexo es correcto")
        End If

    End Function






End Class
