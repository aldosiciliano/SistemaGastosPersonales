Public Class Balance
    Public Class Balance
        Public Property TotalIngresosDia As Decimal
        Public Property TotalGastosDia As Decimal

        Public Property TotalIngresosSemana As Decimal
        Public Property TotalGastosSemana As Decimal

        Public Property TotalIngresosMes As Decimal
        Public Property TotalGastosMes As Decimal

        Public Property TotalIngresosAnio As Decimal
        Public Property TotalGastosAnio As Decimal

        Public Property TotalIngresosTotal As Decimal
        Public Property TotalGastosTotal As Decimal

        ' Propiedades calculadas
        Public ReadOnly Property BalanceDia As Decimal
            Get
                Return TotalIngresosDia - TotalGastosDia
            End Get
        End Property

        Public ReadOnly Property BalanceSemana As Decimal
            Get
                Return TotalIngresosSemana - TotalGastosSemana
            End Get
        End Property

        Public ReadOnly Property BalanceMes As Decimal
            Get
                Return TotalIngresosMes - TotalGastosMes
            End Get
        End Property

        Public ReadOnly Property BalanceAnio As Decimal
            Get
                Return TotalIngresosAnio - TotalGastosAnio
            End Get
        End Property

        Public ReadOnly Property BalanceTotal As Decimal
            Get
                Return TotalIngresosTotal - TotalGastosTotal
            End Get
        End Property
    End Class
End Class