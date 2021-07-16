--**************************************************************************
-- [CAR RENTAL MANGER] Database SQL-Script
--**************************************************************************

--==========================================================================
-- ♦ Base de données (Version serveur)
--==========================================================================
IF EXISTS (SELECT
            *
        FROM sys.databases
        WHERE name = 'car_rental_database')
    DROP DATABASE car_rental_database;
CREATE DATABASE car_rental_database;
USE car_rental_database;

--==========================================================================
-- ♦ Tables (8 tables)
--==========================================================================
----------------------------------------------------------------------------
-- 1) Client
----------------------------------------------------------------------------
CREATE TABLE client (
    id_client_pk INT PRIMARY KEY IDENTITY
   ,photo_client IMAGE
   ,nom_client VARCHAR(50) NOT NULL
   ,prenom_client VARCHAR(50) NOT NULL
   ,nationalite_client VARCHAR(50) NOT NULL DEFAULT 'Marocain'
   ,date_naissance_client DATE
   ,lieu_naissance_client VARCHAR(50) DEFAULT 'Marrakech'
   ,adresse_domicile_client VARCHAR(100) NOT NULL
   ,ville_domicile_client VARCHAR(50) NOT NULL DEFAULT 'Marrakech'
   ,code_postal_domicile_client VARCHAR(50) NOT NULL
   ,adresse_residence_client VARCHAR(100) NOT NULL
   ,ville_residence_client VARCHAR(50) NOT NULL DEFAULT 'Marrakech'
   ,code_postal_residence_client VARCHAR(50) NOT NULL
   ,telephone_portable_client VARCHAR(50) NOT NULL
   ,telephone_fixe_client VARCHAR(50)
   ,fax_client VARCHAR(50)
   ,email_client VARCHAR(50)
   ,type_client VARCHAR(50) NOT NULL DEFAULT 'Particulier'
   ,id_national_client VARCHAR(50) UNIQUE NOT NULL
   ,type_id_national_client VARCHAR(50) NOT NULL DEFAULT 'CIN'
   ,date_heure_delivraison_id_national_client DATETIME NOT NULL DEFAULT GETDATE()
   ,lieu_delivraison_id_national_client VARCHAR(50) NOT NULL DEFAULT 'Marrakech'
   ,id_permis_conduire_client VARCHAR(50) UNIQUE NOT NULL
   ,date_heure_delivraison_permis_client DATETIME NOT NULL DEFAULT GETDATE()
   ,lieu_delivraison_permis_Client VARCHAR(50) NOT NULL DEFAULT 'Marrakech'
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
);

----------------------------------------------------------------------------
-- 2) Agence
----------------------------------------------------------------------------
CREATE TABLE agence (
    id_agence_pk INT PRIMARY KEY IDENTITY
   ,photo_agence IMAGE
   ,nom_agence VARCHAR(50) NOT NULL
   ,description_agence VARCHAR(100)
   ,date_creation_agence DATE
   ,adresse_agence VARCHAR(100) NOT NULL
   ,ville_agence VARCHAR(50) NOT NULL DEFAULT 'Marrakech'
   ,code_postal_agence VARCHAR(50) NOT NULL
   ,telephone_agence VARCHAR(50) NOT NULL
   ,fax_agence VARCHAR(50)
   ,email_agence VARCHAR(50)
   ,lien_Web_agence TEXT
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
)

----------------------------------------------------------------------------
-- 3) Employé (Référence Agence)
----------------------------------------------------------------------------
CREATE TABLE employe (
    id_employe_pk INT PRIMARY KEY IDENTITY
   ,photo_employe IMAGE
   ,nom_employe VARCHAR(50) NOT NULL
   ,prenom_employe VARCHAR(50) NOT NULL
   ,nationalite_employe VARCHAR(50) DEFAULT 'Marocain'
   ,date_naissance_employe DATE
   ,lieu_naissance_employe VARCHAR(50) DEFAULT 'Marrakech'
   ,adresse_domicile_employe VARCHAR(100)
   ,ville_domicile_employe VARCHAR(50) DEFAULT 'Marrakech'
   ,code_postal_domicile_employe VARCHAR(50)
   ,telephone_portable_employe VARCHAR(50)
   ,telephone_fixe_employe VARCHAR(50)
   ,fax_employe VARCHAR(50)
   ,email_employe VARCHAR(50)
   ,date_embauche_employe DATE
   ,fonction_employe VARCHAR(50) NOT NULL DEFAULT 'Employé'
   ,id_agence_fk INT FOREIGN KEY REFERENCES agence (id_agence_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
);
----------------------------------------------------------------------------
-- 4) Utilisateur (Référence Employé)
----------------------------------------------------------------------------
CREATE TABLE utilisateur (
    nom_utilisateur_pk VARCHAR(50) PRIMARY KEY
   ,mot_passe_utilisateur VARCHAR(50) NOT NULL
   ,role_utilisateur VARCHAR(50) NOT NULL DEFAULT 'Utilisateur'
   ,id_employe_fk INT FOREIGN KEY REFERENCES employe (id_employe_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,date_heure_derniere_connexion_utilisatur DATETIME
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
);

----------------------------------------------------------------------------
-- 6) Parc
----------------------------------------------------------------------------
CREATE TABLE parc (
    id_parc_pk INT PRIMARY KEY IDENTITY
   ,photo_parc IMAGE
   ,nom_parc VARCHAR(50)
   ,description_parc VARCHAR(100)
   ,date_creation_parc DATE
   ,adresse_parc VARCHAR(100) NOT NULL
   ,ville_parc VARCHAR(50) NOT NULL DEFAULT 'Marrakech'
   ,code_postal_parc VARCHAR(50) NOT NULL
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
)

----------------------------------------------------------------------------
-- 4) Véhicule (Référene Agence et Parc)
----------------------------------------------------------------------------
CREATE TABLE vehicule (
    immatriculation_vehicule_pk VARCHAR(50) PRIMARY KEY
   ,photo_vehicule IMAGE
   ,type_vehicule VARCHAR(50) NOT NULL DEFAULT 'Voiture'
   ,marque_vehicule VARCHAR(50) NOT NULL
   ,description_vehicule VARCHAR(100)
   ,distance_parcourue_vehicule FLOAT NOT NULL DEFAULT 0
   ,type_energie_vehicule VARCHAR(50) NOT NULL DEFAULT 'Essence'
   ,quantite_energie_vehicule FLOAT NOT NULL DEFAULT 0
   ,prix_location_vehicule MONEY NOT NULL DEFAULT 0
   ,date_achat_vehicule DATE
   ,date_derniere_maintenance_vehicule DATE
   ,id_agence_fk INT FOREIGN KEY REFERENCES agence (id_agence_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,id_parc_fk INT FOREIGN KEY REFERENCES parc (id_parc_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
)

----------------------------------------------------------------------------
-- 7) Contrat (Référence Client, Véhicule, Employé, Agence et Utilisateur)
----------------------------------------------------------------------------
CREATE TABLE contrat (
    id_contrat_pk INT PRIMARY KEY IDENTITY
   ,id_client_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
   ,immatriculation_vehicule_fk VARCHAR(50) FOREIGN KEY REFERENCES vehicule (immatriculation_vehicule_pk)
   ,id_client_compagnon_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,id_employe_conducteur_fk INT FOREIGN KEY REFERENCES employe (id_employe_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,description_equipements_speciaux_contrat VARCHAR(100)
   ,date_heure_depart_vehicule_contrat DATETIME NOT NULL
   ,date_heure_retour_vehicule_contrat DATETIME NOT NULL
   ,id_agence_depart_contrat_fk INT FOREIGN KEY REFERENCES agence (id_agence_pk)
   ,id_agence_retour_contrat_fk INT FOREIGN KEY REFERENCES agence (id_agence_pk)
   ,lieu_depart_vehicule_contrat VARCHAR(100) NOT NULL DEFAULT 'Marrakech'
   ,lieu_retour_vehicule_contrat VARCHAR(100) NOT NULL DEFAULT 'Marrakech'
   ,frais_conducteur_contrat MONEY NOT NULL DEFAULT 0
   ,frais_equipements_speciaux_contrat MONEY NOT NULL DEFAULT 0
   ,montant_forfait_contrat MONEY NOT NULL DEFAULT 0
   ,montant_remise_contrat MONEY NOT NULL DEFAULT 0
   ,mode_paiement_contrat VARCHAR(50) NOT NULL DEFAULT 'Espèce'
   ,nom_utilisateur_commentateur_contrat_fk VARCHAR(50) FOREIGN KEY REFERENCES utilisateur (nom_utilisateur_pk)
   ,commentaire_contrat VARCHAR(100)
   ,UNIQUE (id_client_fk, immatriculation_vehicule_fk, date_heure_depart_vehicule_contrat)
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
)

----------------------------------------------------------------------------
-- 8) Réservation (Référence Client, Véhicule, Employé, Agence et Utilisateur)
----------------------------------------------------------------------------
CREATE TABLE reservation (
    id_reservation INT PRIMARY KEY IDENTITY
   ,id_client_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
   ,immatriculation_vehicule_fk VARCHAR(50) FOREIGN KEY REFERENCES vehicule (immatriculation_vehicule_pk)
   ,id_client_compagnon_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,id_employe_conducteur_fk INT FOREIGN KEY REFERENCES employe (id_employe_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,description_equipements_speciaux_contrat VARCHAR(100)
   ,date_heure_depart_vehicule_reservation DATETIME NOT NULL
   ,date_heure_retour_vehicule_reservation DATETIME NOT NULL
   ,id_agence_depart_reservation_fk INT FOREIGN KEY REFERENCES agence (id_agence_pk)
   ,id_agence_retour_reservation_fk INT FOREIGN KEY REFERENCES agence (id_agence_pk)
   ,lieu_depart_vehicule_reservation VARCHAR(100) NOT NULL DEFAULT 'Marrakech'
   ,lieu_retour_vehicule_reservation VARCHAR(100) NOT NULL DEFAULT 'Marrakech'
   ,frais_conducteur_reservation MONEY NOT NULL DEFAULT 0
   ,frais_equipements_speciaux_reservation MONEY NOT NULL DEFAULT 0
   ,montant_forfait_reservation MONEY NOT NULL DEFAULT 0
   ,montant_remise_reservation MONEY NOT NULL DEFAULT 0
   ,mode_paiement_reservation VARCHAR(50) NOT NULL DEFAULT 'Espèce'
   ,nom_utilisateur_commentateur_reservation_fk VARCHAR(50) FOREIGN KEY REFERENCES utilisateur (nom_utilisateur_pk)
   ,commentaire_reservation VARCHAR(100)
   ,UNIQUE (id_client_fk, immatriculation_vehicule_fk, date_heure_depart_vehicule_reservation)
   ,_row_insert_datetime DATETIME NOT NULL DEFAULT GETDATE()
   ,_row_update_datetime DATETIME NULL
   ,_row_delete_datetime DATETIME NULL
);

--==========================================================================
-- ♦ Vues
--==========================================================================


--==========================================================================
-- ♦ Procédures
--==========================================================================

--==========================================================================
-- ♦ Déclencheurs
--==========================================================================
CREATE TRIGGER trg_no_delete_client
	ON client
	INSTEAD OF DELETE
AS 
BEGIN
	PRINT 'Suppression physique interdite !';
    PRINT 'Pour supprimer virtuellemnt une ligne modifiez la valeur NULL de sa colonne row_delete_date';
END
GO
