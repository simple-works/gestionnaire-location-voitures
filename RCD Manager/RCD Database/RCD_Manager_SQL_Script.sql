--**************************************************************************
-- [RCD MANAGER] Database SQL-Script
--**************************************************************************
--CREATE DATABASE RCD_Manager;
--USE RCD_Manager;
--==========================================================================
-- ♦ Tables (6 tables)
--==========================================================================
----------------------------------------------------------------------------
-- 1) Client
----------------------------------------------------------------------------
CREATE TABLE Client (
    id_client_pk INT PRIMARY KEY IDENTITY
   ,photo_client IMAGE
   ,nom_client VARCHAR(50) 
   ,prenom_client VARCHAR(50) 
   ,nationalite_client VARCHAR(50) DEFAULT 'Marocain'
   ,date_naissance_client DATE
   ,lieu_naissance_client VARCHAR(50) DEFAULT 'Marrakech'
   ,adresse_domicile_client VARCHAR(100) 
   ,ville_domicile_client VARCHAR(50)  DEFAULT 'Marrakech'
   ,code_postal_domicile_client VARCHAR(50) 
   ,adresse_residence_client VARCHAR(100) 
   ,ville_residence_client VARCHAR(50)  DEFAULT 'Marrakech'
   ,code_postal_residence_client VARCHAR(50) 
   ,telephone_portable_client VARCHAR(50) 
   ,telephone_fixe_client VARCHAR(50)
   ,fax_client VARCHAR(50)
   ,email_client VARCHAR(50)
   ,type_client VARCHAR(50)  DEFAULT 'Particulier'
   ,id_national_client VARCHAR(50) UNIQUE 
   ,type_id_national_client VARCHAR(50)  DEFAULT 'CIN'
   ,date_heure_delivraison_id_national_client DATETIME  DEFAULT GETDATE()
   ,lieu_delivraison_id_national_client VARCHAR(50)  DEFAULT 'Marrakech'
   ,id_permis_conduire_client VARCHAR(50) UNIQUE 
   ,date_heure_delivraison_permis_client DATETIME  DEFAULT GETDATE()
   ,lieu_delivraison_permis_Client VARCHAR(50)  DEFAULT 'Marrakech'
);

----------------------------------------------------------------------------
-- 2) Employé
----------------------------------------------------------------------------
CREATE TABLE Employe (
    id_employe_pk INT PRIMARY KEY IDENTITY
   ,photo_employe IMAGE
   ,nom_employe VARCHAR(50) 
   ,prenom_employe VARCHAR(50) 
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
   ,fonction_employe VARCHAR(50)  DEFAULT 'Employé'
);
----------------------------------------------------------------------------
-- 3) Utilisateur
----------------------------------------------------------------------------
CREATE TABLE Utilisateur (
    nom_utilisateur_pk VARCHAR(50) PRIMARY KEY
   ,mot_passe_utilisateur VARCHAR(50) 
   ,photo_utilisateur IMAGE
   ,role_utilisateur VARCHAR(50)  DEFAULT 'Utilisateur'
   ,date_heure_derniere_connexion_utilisateur DATETIME
);

----------------------------------------------------------------------------
-- 4) Véhicule
----------------------------------------------------------------------------
CREATE TABLE Vehicule (
    immatriculation_vehicule_pk VARCHAR(50) PRIMARY KEY
   ,photo_vehicule IMAGE
   ,type_vehicule VARCHAR(50)  DEFAULT 'Voiture'
   ,marque_vehicule VARCHAR(50) 
   ,description_vehicule VARCHAR(100)
   ,distance_parcourue_vehicule FLOAT  DEFAULT 0
   ,type_energie_vehicule VARCHAR(50)  DEFAULT 'Essence'
   ,quantite_energie_vehicule FLOAT  DEFAULT 0
   ,prix_location_vehicule MONEY  DEFAULT 0
   ,date_achat_vehicule DATE
   ,date_derniere_maintenance_vehicule DATE
)

----------------------------------------------------------------------------
-- 5) Contrat (Référence Client, Véhicule, Employé)
----------------------------------------------------------------------------
CREATE TABLE Contrat (
    id_contrat_pk INT PRIMARY KEY IDENTITY
   ,id_client_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
   ,immatriculation_vehicule_fk VARCHAR(50) FOREIGN KEY REFERENCES vehicule (immatriculation_vehicule_pk)
   ,id_client_compagnon_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,id_employe_conducteur_fk INT FOREIGN KEY REFERENCES employe (id_employe_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,description_equipements_speciaux_contrat VARCHAR(100)
   ,date_heure_depart_vehicule_contrat DATETIME 
   ,date_heure_retour_vehicule_contrat DATETIME 
   ,lieu_depart_vehicule_contrat VARCHAR(100)  DEFAULT 'Marrakech'
   ,lieu_retour_vehicule_contrat VARCHAR(100)  DEFAULT 'Marrakech'
   ,frais_conducteur_contrat MONEY  DEFAULT 0
   ,frais_equipements_speciaux_contrat MONEY  DEFAULT 0
   ,montant_forfait_contrat MONEY  DEFAULT 0
   ,montant_remise_contrat MONEY  DEFAULT 0
   ,mode_paiement_contrat VARCHAR(50)  DEFAULT 'Espèce'
   ,UNIQUE (id_client_fk, immatriculation_vehicule_fk, date_heure_depart_vehicule_contrat)
)

----------------------------------------------------------------------------
-- 6) Réservation (Référence Client, Véhicule, Employé)
----------------------------------------------------------------------------
CREATE TABLE Reservation (
    id_reservation_pk INT PRIMARY KEY IDENTITY
   ,id_client_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
   ,immatriculation_vehicule_fk VARCHAR(50) FOREIGN KEY REFERENCES vehicule (immatriculation_vehicule_pk)
   ,id_client_compagnon_fk INT FOREIGN KEY REFERENCES client (id_client_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,id_employe_conducteur_fk INT FOREIGN KEY REFERENCES employe (id_employe_pk)
    ON DELETE SET NULL ON UPDATE CASCADE
   ,description_equipements_speciaux_reservation VARCHAR(100)
   ,date_heure_depart_vehicule_reservation DATETIME 
   ,date_heure_retour_vehicule_reservation DATETIME
   ,lieu_depart_vehicule_reservation VARCHAR(100)  DEFAULT 'Marrakech'
   ,lieu_retour_vehicule_reservation VARCHAR(100) DEFAULT 'Marrakech'
   ,frais_conducteur_reservation MONEY  DEFAULT 0
   ,frais_equipements_speciaux_reservation MONEY  DEFAULT 0
   ,montant_forfait_reservation MONEY  DEFAULT 0
   ,montant_remise_reservation MONEY  DEFAULT 0
   ,mode_paiement_reservation VARCHAR(50)  DEFAULT 'Espèce'
   ,UNIQUE (id_client_fk, immatriculation_vehicule_fk, date_heure_depart_vehicule_reservation)
);
