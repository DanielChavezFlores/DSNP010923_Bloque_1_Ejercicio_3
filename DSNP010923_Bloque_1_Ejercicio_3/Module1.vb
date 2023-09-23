Module Module1

    Sub Main(Args As String())

        Dim monto, total As Double
        Dim descuento As Decimal


        Console.WriteLine("Ingrese el monto")
        monto = Console.ReadLine()

        If (monto < 0) Then

            While (monto < 0)

                Console.WriteLine("Ingrese un monto mayor a 0")
                monto = Console.ReadLine()

            End While
        Else
            Select Case monto
                Case 0 To 249.999999
                    Console.WriteLine("Su descuento es del 5%")
                    descuento = monto * 0.05
                    total = monto - descuento
                    Console.WriteLine("El descuento es de:$" & descuento & " " & "El total a pagar es:$" & total)
                    Console.ReadLine()
                Case 250 To 499.999999
                    Console.WriteLine("Su descuento es del 10%")
                    descuento = monto * 0.1
                    total = monto - descuento
                    Console.WriteLine("El descuento es de:$" & descuento & " " & "El total a pagar es:$" & total)
                    Console.ReadLine()
                Case 500 To 999.99999
                    Console.WriteLine("Su descuento es del 20%")
                    descuento = monto * 0.2
                    total = monto - descuento
                    Console.WriteLine("El descuento es de:$" & descuento & " " & "El total a pagar es:$" & total)
                    Console.ReadLine()
                Case Else
                    Console.WriteLine("Su descuento es del 30%")
                    descuento = monto * 0.3
                    total = monto - descuento
                    Console.WriteLine("El descuento es de:$" & descuento & " " & "El total a pagar es:$" & total)
                    Console.ReadLine()
            End Select

        End If




    End Sub

End Module
