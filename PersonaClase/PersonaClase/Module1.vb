Module Module1

    Sub Main()
        Dim nombre As String
        Dim edad As Integer
        Dim sexo As Char

        Dim peso As Double
        Dim altura As Double


        Console.WriteLine("Introduzca nombre ")
        nombre = Console.ReadLine()
        Console.WriteLine("Introduzca edad ")
        edad = Console.ReadLine()
        Console.WriteLine("Introduzca sexo ")
        sexo = Console.ReadLine()
        Console.WriteLine("Introduzca peso ")
        peso = Console.ReadLine()
        Console.WriteLine("Introduzca altura ")
        altura = Console.ReadLine()
        Dim persona As Persona = New Persona(nombre, edad, sexo, peso, altura)
        Dim persona2 As Persona = New Persona(nombre, edad, sexo)
        Dim persona3 As Persona = New Persona()
        persona3.setAltura(1.95)
        persona3.setPeso(80)
        persona3.setNombre("PepitoElGrillo")
        persona3.setEdad(30)



        Console.WriteLine("Persona " + persona.toString())
        imprimirResultadoImc(persona.calcularIMC())
        imprimirResultadoEdad(persona.esMayorDeEdad())
        Console.WriteLine("Persona2 " + persona2.toString())
        imprimirResultadoImc(persona2.calcularIMC())
        imprimirResultadoEdad(persona2.esMayorDeEdad())
        Console.WriteLine("Persona3 " + persona3.toString())
        imprimirResultadoImc(persona3.calcularIMC())
        imprimirResultadoEdad(persona3.esMayorDeEdad())
        Console.ReadLine()
    End Sub

    Function imprimirResultadoImc(res As Integer)
        If (res = -1) Then
            Console.WriteLine("Infrapeso")
        ElseIf (res = 0) Then
            Console.WriteLine("Peso ideal")
        Else
            Console.WriteLine("Estas Obeso")
        End If
    End Function

    Function imprimirResultadoEdad(res As Boolean)
        If (res = True) Then
            Console.WriteLine("Eres mayor de edad")
        Else
            Console.WriteLine("No eres mayor de edad")
        End If

    End Function

End Module
