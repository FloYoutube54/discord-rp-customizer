﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class FR
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Utils.FR", GetType(FR).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Accéder a l&apos;espace développeurs.
        '''</summary>
        Friend Shared ReadOnly Property AccessDeveloppersSpace() As String
            Get
                Return ResourceManager.GetString("AccessDeveloppersSpace", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ajouter.
        '''</summary>
        Friend Shared ReadOnly Property Add() As String
            Get
                Return ResourceManager.GetString("Add", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Appliquer.
        '''</summary>
        Friend Shared ReadOnly Property Apply() As String
            Get
                Return ResourceManager.GetString("Apply", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Annuler.
        '''</summary>
        Friend Shared ReadOnly Property Cancel() As String
            Get
                Return ResourceManager.GetString("Cancel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Changer le texte.
        '''</summary>
        Friend Shared ReadOnly Property ChangeText() As String
            Get
                Return ResourceManager.GetString("ChangeText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Choisir.
        '''</summary>
        Friend Shared ReadOnly Property Choose() As String
            Get
                Return ResourceManager.GetString("Choose", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Pour pouvoir utiliser une application personnalisée, vous devez d&apos;abord la créer dans l&apos;espace développeurs de Discord. Une application sert : 
        '''    1. A être utilisée pour créer un Rich Presence dans votre jeu
        '''    2. A créer un bot pour un serveur Discord.
        '''
        '''Pour y accéder, cliquez sur le bouton ci-dessous..
        '''</summary>
        Friend Shared ReadOnly Property CustomApp_Step1() As String
            Get
                Return ResourceManager.GetString("CustomApp_Step1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 1. Créer l&apos;application.
        '''</summary>
        Friend Shared ReadOnly Property CustomApp_Step1Title() As String
            Get
                Return ResourceManager.GetString("CustomApp_Step1Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;ID client va servir à se connecter à l&apos;application afin de créer le Rich Presence. Avec une application personnalisée, vous pouvez : 
        '''    1. Personnaliser le titre du Rich Presence
        '''    2. Personnaliser les images disponibles pour le Rich Presence
        '''
        '''Veuillez copier et coller l&apos;ID client dans la zone de texte ci-dessous :.
        '''</summary>
        Friend Shared ReadOnly Property CustomApp_Step2() As String
            Get
                Return ResourceManager.GetString("CustomApp_Step2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 2. Obtenir l&apos;ID client.
        '''</summary>
        Friend Shared ReadOnly Property CustomApp_Step2Title() As String
            Get
                Return ResourceManager.GetString("CustomApp_Step2Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le logiciel est prêt à être utilisé avec l&apos;application personnalisée !.
        '''</summary>
        Friend Shared ReadOnly Property CustomApp_Step3() As String
            Get
                Return ResourceManager.GetString("CustomApp_Step3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 3. Le logiciel est prêt !.
        '''</summary>
        Friend Shared ReadOnly Property CustomApp_Step3Title() As String
            Get
                Return ResourceManager.GetString("CustomApp_Step3Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Image personnalisée.
        '''</summary>
        Friend Shared ReadOnly Property CustomPicture() As String
            Get
                Return ResourceManager.GetString("CustomPicture", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Entrez la clé (key) de l&apos;image :.
        '''</summary>
        Friend Shared ReadOnly Property CustomPictureInput() As String
            Get
                Return ResourceManager.GetString("CustomPictureInput", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Supprimer.
        '''</summary>
        Friend Shared ReadOnly Property Delete() As String
            Get
                Return ResourceManager.GetString("Delete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ne pas enregistrer.
        '''</summary>
        Friend Shared ReadOnly Property DontSave() As String
            Get
                Return ResourceManager.GetString("DontSave", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à (vide).
        '''</summary>
        Friend Shared ReadOnly Property Empty() As String
            Get
                Return ResourceManager.GetString("Empty", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ligne 1.
        '''</summary>
        Friend Shared ReadOnly Property Line1() As String
            Get
                Return ResourceManager.GetString("Line1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Veuillez entrer un texte pour la première ligne :.
        '''</summary>
        Friend Shared ReadOnly Property Line1Input() As String
            Get
                Return ResourceManager.GetString("Line1Input", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ligne 2.
        '''</summary>
        Friend Shared ReadOnly Property Line2() As String
            Get
                Return ResourceManager.GetString("Line2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Veuillez entrer un texte pour la deuxième ligne :.
        '''</summary>
        Friend Shared ReadOnly Property Line2Input() As String
            Get
                Return ResourceManager.GetString("Line2Input", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;A propos....
        '''</summary>
        Friend Shared ReadOnly Property MNU_About() As String
            Get
                Return ResourceManager.GetString("MNU_About", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Applications personnalisées.
        '''</summary>
        Friend Shared ReadOnly Property MNU_CustomApps() As String
            Get
                Return ResourceManager.GetString("MNU_CustomApps", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Soutenir.
        '''</summary>
        Friend Shared ReadOnly Property MNU_Donate() As String
            Get
                Return ResourceManager.GetString("MNU_Donate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Quitter.
        '''</summary>
        Friend Shared ReadOnly Property MNU_Exit() As String
            Get
                Return ResourceManager.GetString("MNU_Exit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Fichier.
        '''</summary>
        Friend Shared ReadOnly Property MNU_File() As String
            Get
                Return ResourceManager.GetString("MNU_File", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Nouveau.
        '''</summary>
        Friend Shared ReadOnly Property MNU_New() As String
            Get
                Return ResourceManager.GetString("MNU_New", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Ouvrir.
        '''</summary>
        Friend Shared ReadOnly Property MNU_Open() As String
            Get
                Return ResourceManager.GetString("MNU_Open", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à En&amp;lever.
        '''</summary>
        Friend Shared ReadOnly Property MNU_Remove() As String
            Get
                Return ResourceManager.GetString("MNU_Remove", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Rich Presence.
        '''</summary>
        Friend Shared ReadOnly Property MNU_RP() As String
            Get
                Return ResourceManager.GetString("MNU_RP", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Enregistrer.
        '''</summary>
        Friend Shared ReadOnly Property MNU_Save() As String
            Get
                Return ResourceManager.GetString("MNU_Save", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à E&amp;nregistrer sous....
        '''</summary>
        Friend Shared ReadOnly Property MNU_SaveAs() As String
            Get
                Return ResourceManager.GetString("MNU_SaveAs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Mises à jours.
        '''</summary>
        Friend Shared ReadOnly Property MNU_Updates() As String
            Get
                Return ResourceManager.GetString("MNU_Updates", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &amp;Site Internet.
        '''</summary>
        Friend Shared ReadOnly Property MNU_Website() As String
            Get
                Return ResourceManager.GetString("MNU_Website", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Nom.
        '''</summary>
        Friend Shared ReadOnly Property Name() As String
            Get
                Return ResourceManager.GetString("Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Vous avez du travail non-enregistré.
        '''</summary>
        Friend Shared ReadOnly Property NotSaved_Caption() As String
            Get
                Return ResourceManager.GetString("NotSaved_Caption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Souhaitez-vous enregistrer ce RP ?.
        '''</summary>
        Friend Shared ReadOnly Property NotSaved_InstructionText() As String
            Get
                Return ResourceManager.GetString("NotSaved_InstructionText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Les dernières modifications de ce RP n&apos;ont pas été enregistrées. Souhaitez-vous les enregistrer maintenant ?.
        '''</summary>
        Friend Shared ReadOnly Property NotSaved_Text() As String
            Get
                Return ResourceManager.GetString("NotSaved_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Maintenant.
        '''</summary>
        Friend Shared ReadOnly Property Now() As String
            Get
                Return ResourceManager.GetString("Now", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à OK.
        '''</summary>
        Friend Shared ReadOnly Property OK() As String
            Get
                Return ResourceManager.GetString("OK", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Coller.
        '''</summary>
        Friend Shared ReadOnly Property Past() As String
            Get
                Return ResourceManager.GetString("Past", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrer et continuer.
        '''</summary>
        Friend Shared ReadOnly Property SaveAndContinue() As String
            Get
                Return ResourceManager.GetString("SaveAndContinue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrer et quitter.
        '''</summary>
        Friend Shared ReadOnly Property SaveAndExit() As String
            Get
                Return ResourceManager.GetString("SaveAndExit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouvrir un fichier.
        '''</summary>
        Friend Shared ReadOnly Property SaveAndOpen_Caption() As String
            Get
                Return ResourceManager.GetString("SaveAndOpen_Caption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Vous êtes sur le point d&apos;ouvrir un autre fichier. Or celui-ci n&apos;est pas enregistré. Souhaitez-vous l&apos;enregistrer avant de continuer ?.
        '''</summary>
        Friend Shared ReadOnly Property SaveAndOpen_InstructionText() As String
            Get
                Return ResourceManager.GetString("SaveAndOpen_InstructionText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Fichier non enregistré !.
        '''</summary>
        Friend Shared ReadOnly Property SaveAndOpen_Text() As String
            Get
                Return ResourceManager.GetString("SaveAndOpen_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Depuis.
        '''</summary>
        Friend Shared ReadOnly Property SinceTimestamp() As String
            Get
                Return ResourceManager.GetString("SinceTimestamp", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
