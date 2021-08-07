using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anoteitor
{
    class Silaba
    {

//        Private P As String
//Private Sil As Collection

//Enum TipoVocalX
//    Ninguna = 0
//    Cerrada = -1
//    Abierta = 1
//End Enum


//Public Property Let Palabra(Palabra As String)

//P = Palabra
//Silabear

//End Property


//Public Property Get Silabas() As Integer
//Silabas = Sil.Count
//End Property

//Public Property Get Tipo() As String

//Dim n As Integer
//Dim T As String

//T = ""
//n = Sil.Count

//If n > 0 Then
//    Select Case n
//     Case 1: T = "Monosilaba"
//     Case 2: T = "bisilaba"
//     Case 3: T = "Trisilaba"
//     Case Else: T = "Polisilaba"
//    End Select
//End If

//Tipo = T

//End Property

//Public Property Get Silaba(Indice As Integer) As String

//Dim n As Integer
//Dim S As String

//S = ""
//n = Sil.Count

//If Indice >= 1 And Indice <= n Then S = Sil((n - Indice) + 1)

//Silaba = S

//End Property


//Public Function tieneTilde(C As String) As Boolean

//   Dim V As Boolean

//    V = True
//    C = LCase(C)


//    Select Case C
//     Case "á", "é", "í", "ó", "ú":
//     Case Else: V = False
//    End Select

// tieneTilde = V

//End Function


//Public Function Vocal(C As String) As Boolean

//   Dim V As Boolean


//    V = True
//    C = LCase(C)


//    Select Case C
//     Case "a", "á", "e", "é", "i", "í", "o", "ó", "u", "ú", "ü":
//     Case Else: V = False
//    End Select

// Vocal = V

//End Function



//Public Function TipoVocal(C As String) As TipoVocalX

// Dim V As TipoVocalX


// V = Ninguna

// If Vocal(C) Then

//    V = Cerrada
//    C = LCase(C)


//    Select Case C
//     Case "i", "í", "u", "ú", "ü":
//     Case Else: V = Abierta
//    End Select

//  End If

// TipoVocal = V

//End Function



//Private Function Letra(C As String) As Boolean

//   Dim L As Boolean


//   L = False
//   C = LCase(C)


//   If(C >= "a" And C <= "z" Or C = "ñ") Or _
//     (C = "á" Or C = "é" Or C = "í" Or C = "ó" Or C = "ú" Or C = "ü") Then L = True


//   Letra = L

//End Function



//Private Function Comb(C As String) As Boolean

//   Dim Cmb As Boolean


//   Cmb = True

//   C = LCase(C)

//   Select Case C
//    Case "bl", "br":
//    Case "cl", "cr":
//    Case "dl", "dr":
//    Case "fl", "fr":
//    Case "gl", "gr":
//    Case "pl", "pr":
//    Case "tl", "tr":
//    Case "kl", "kr":
//    Case "ll", "rr", "ch", "qu"
//    Case Else: Cmb = False
//   End Select

// Comb = Cmb

//End Function



//Private Function Silabear() As Boolean

// Dim i As Integer, V As Integer, L As Integer
// Dim C As String, Sig As String, Cmb As String, S As String
// Dim T As Boolean, Vc As Boolean, Vs As Boolean, Va As Boolean
// Dim Tvs As TipoVocalX, Tvc As TipoVocalX, Tva As TipoVocalX

// V = 0:  S = "":  a = "":  Sig = "":  L = Len(P) :   P = Trim(P) :  Va = False

//  Frm.textSeg.Text = ""

// If P <> "" Then

//           For i = L To 1 Step -1


//                  T = False
  
//                  C = Mid(P, i, 1)
  

//                  Vc = Vocal(C):    Vs = Vocal(Sig)
  
//                  Tvc = TipoVocal(C):  Tvs = TipoVocal(Sig)
  
//                  Cmb = C + Sig
  

//                  If (Vc And Not Vs) Then V = V + 1


//                If(V > 1 And Not Vs) Then
//                   T = True
//                ElseIf(Not Vc And Not Vs And Not Comb(Cmb)) And(V = 1 And i > 1) Then
//                  T = True
//                ElseIf(Tvc = Abierta And Tvs = Abierta) Or _
//                      (Tvc = Cerrada And tieneTilde(C) And Vs) Or _
//                      (Tvc = Abierta And (Tvs = Cerrada And tieneTilde(Sig))) Or _
//                      ((Vc And Vs) And(C = Sig)) Then
//                   T = True:  V = V + 1
//                End If

//                If T = True Then
//                  Sil.Add S:   S = C:    V = V - 1
//                Else
//                  S = C + S
//                End If


//                Sig = C
//         Next

//        Sil.Add S

// Else
//  Silabear = False
// End If


// Silabear = True

//End Function

//Private Sub Class_Initialize()

//P = ""
//Set Sil = New Collection

//End Sub

    }
}
