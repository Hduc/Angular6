interface Contact {

    idcontact: number,
    idnomContact: string,
    idsociete: number,
    idutilisateur: number,
    idutilisateurCreateur: number,
    idtypeUtilisateur: number,
    idlisteFonction: number,
    idcivilite: number,
    idstatut: number,
    prenomContact: string,
    nomContact: string,
    telephoneContact: string,
    portableContact: string,
    faxContact: string,
    emailContact: string,
    emailContact2: string,
    nombreRefusEmail: number,
    fonctionContact: string,
    login: number,
    motdePasse: string,
    acheteur: boolean,
    vendeur: boolean,
    listeRougeMail: boolean,
    listeRougeFax: boolean,
    listeRougeTelephone: boolean,
    importanceContact: number,
    oldIdcontact: number,
    idlisteBase: number,
    dateMajcontact: Date,
    dateMajmanuelleContact: Date,
    dateCreationContact: Date,
    mailCorrect: string,
    listeRougePortable: boolean,
    // courriel: string,
    // postal: string,
    // ville: string,
    // pays: string,
}
interface Obj_Contact {
    idcontact: number,
    prenomContact: string,
    nomContact: string,
    nomSociete: string,
    telephoneContact:string ,
    fonctionContact: string,
    emailContact: string,
    idcivilite: number,
    portableContact: string,
    idListeFonction:number,
    fonctionGeneriqueAbrege: string,
    fonctionGenerique: string,
    idStatut: number,
    contactPardefaut : number,
    idTypeFonction: string,
    idSociete: number,
    photoUrl: string,
    // idlisteFonction: number,
    idutilisateur : number,
}
interface ObjectResult_Contact {
    description: string;
    errorCode: string;
    result: Contact[];
}
interface Result_Contact {
    description: string;
    errorCode: string;
    result: number;
}
// interface Object_Contact {
//     description: string;
//     errorCode: string;
//     result: Contact;
// }
interface Object_Contact {
    description: string;
    errorCode: string;
    result: Obj_Contact;
}
interface Result_Obj_Contact {
    description: string;
    errorCode: string;
    result: Obj_Contact[];
}