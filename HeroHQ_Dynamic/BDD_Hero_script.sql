/* Il est temps de créer votre Base de Données (BDD). Ce script permet de vérifier l'existance
 * et de remplir une BDD du nom de "BDD_Hero". Pour ce faire :
 *		1°) Lancer SQL Server Management Studio (SSMS) et connecter vous à (localdb)\MSSQLLocalDB
 *		2°) Effectuer un clic droit sur Bases de données -> Nouvelle base de données...
 *      3°) Appeler la base de données BDD_Hero et cliquer sur OK
 *		4°) Effectuer un clic droit sur BDD_Hero -> Nouvelle requête
 *		5°) Copier-coller ce script en entier et cliquer sur "Executer"
 *			5-1°) Si une erreur apparait à l'écran, appeler un Code Guru
 *		6°) Dans BDD_Hero, dans le dossier "Tables", vous devriez trouver un fichier dbo.Heroes
 *			6-1°) Si le SQL et la gestion de BDD vous intéresse, créer de nouveaux scripts pour afficher, modifier ou ajouter des lignes
 *		7°) Dès que vous avez une table de donnée remplie, plus besoin de ce script ni de SSMS, fermer tout, passez à la suite!
*/

USE [BDD_Hero]
GO
/****** Object:  Table [dbo].[Heroes]    Script Date: 03/03/2017 13:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Heroes](
	[Id] [int] NOT NULL IDENTITY,
	[Nom] [nvarchar](max) NOT NULL,
	[Age] [int] NOT NULL,
	[Pouvoir] [nvarchar](max) NOT NULL,
	[Citation] [nvarchar](max) NOT NULL,
	[Photo] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Genji', 35, N'Cyborg Ninja', N'Mon katana est au service du bien!', N'Genji_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'McCree', 37, N'Colt .45', N'Je suis le roi des duels au soleil.', N'McCree_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Pharah', 32, N'Vol et tire des roquettes', N'Place au déluge de la justice!', N'Pharah_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Reaper', 51, N'Réserve infinie de fusils à pompes', N'Je suis le faucheur...', N'Reaper_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Soldier: 76', 53, N'Viseur tactique', N'La guerre ne s''arrète jamais.', N'Soldier76_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Sombra', 30, N'Hackeuse surdouée', N'Boop!', N'Sombra_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Tracer', 26, N'Contrôle spatio temporel limité', N'Je suis toujours à l''heure ;)', N'Tracer_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Bastion', 30, N'Mitrailleuse lourde sur pattes', N'Beep boop bip bip booooop!', N'Bastion_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Hanzo', 38, N'Arcs et flèches améliorés', N'Je suis le dragon!', N'Hanzo_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Junkrat', 25, N'Immunité aux explosions et lance grenade', N'On va tout faire péter!', N'Junkrat_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Mei', 101, N'Cryostase et contrôle de la glace', N'Je ne voudrai pas jeter un froid...', N'Mei_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Torbjörn', 57, N'Constructeur de génie', N'Pour la dernière fois, je suis suédois!', N'Torbjorn_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Widowmaker', 33, N'Sniper d''élite', N'Une balle, un mort!', N'Widowmaker_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'D.Va', 19, N'Conductrice de Meka', N'Place aux jeunes!', N'Dva_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Reinhardt', 61, N'Chevalier en armure', N'Pour l''honneur et la justice!!!', N'Reinhardt_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Roadhog', 48, N'Apocalypse ambulante', N'Viens par ici que je te montre qui est le boss!', N'Roadhog_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Winston', 17, N'Scientifique en jetpack', N'La science est le moteur de l''humanité', N'Winston_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Zarya', 28, N'Fusil laser lourd', N'Pour la mère patrie!', N'Zarya_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Ana', 60, N'Fusil sniper bionique', N'Bat toi pour tes idéaux!', N'Ana_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Lucio', 26, N'DJ en roller', N'Je m''invites à la fête!', N'Lucio_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Mercy', 37, N'Ange gardien', N'Ha, les miracles de la science moderne...', N'Mercy_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Symmetra', 28, N'Rends la lumière solide', N'Bienvenue dans ma réalité...', N'Symmetra_portrait.png')
GO
INSERT [dbo].[Heroes] ([Nom], [Age], [Pouvoir], [Citation], [Photo]) VALUES (N'Zenyatta', 20, N'Grand sage', N'Votre véritable pouvoir est en vous!', N'Zenyatta_portrait.png')
GO
