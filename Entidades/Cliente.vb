﻿Imports Entidades

Public Class Cliente
    Implements Suspendible

    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger
    Private _fechaNacimiento As Date
    Private _cuentas As List(Of Cuenta)
    Private _activo As Boolean

    Public Sub New()
        Me.Apellido = "Alcoholico"
        Nombre = "Anonimo"
        Documento = 1000
        FechaNacimiento = Date.Now()
        _cuentas = New List(Of Cuenta)
        Activar()
    End Sub

    Public Sub New(Apellido As String, Nombre As String)
        Me.New()
        Me.Apellido = Apellido
        Me.Nombre = Nombre
    End Sub

    Public Sub New(Apellido As String, Nombre As String, Documento As UInteger, FechaNacimiento As Date)
        Me.New(Apellido, Nombre)
        Me.Documento = Documento
        Me.FechaNacimiento = FechaNacimiento
    End Sub

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Apellido & " " & Nombre
    End Function

    Friend Sub addCuenta(cuenta As Cuenta)
        'cuenta.Cliente = Me
        If _activo Then
            _cuentas.Add(cuenta)
        End If
    End Sub

    Friend Sub removeCuenta(cuenta As Cuenta)
        'cuenta.Cliente = Nothing
        _cuentas.Remove(cuenta)
    End Sub

    Public Function getAllCuentas() As List(Of Cuenta)
        Return _cuentas
    End Function

    Public Sub Suspender() Implements Suspendible.Suspender
        _activo = False
    End Sub

    Public Sub Activar() Implements Suspendible.Activar
        _activo = True
    End Sub

    Friend ReadOnly Property Activo() As Boolean
        Get
            Return _activo
        End Get
    End Property
End Class
