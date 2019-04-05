interface Liste_Utilisateur{
    
    civiliteAbregeUtilisateur: string,
    civiliteUtilisateur: string,
    emailUtilisateur: string,
    fonctionGeneriqueUtilisateur: string,
    fonctionUtilisateur: string,
    idResponsable: number,
    idSocieteUtilisateur: number,
    idStatutUtilisateur:number,
    idTypeUtilisateur:number,
    idUtilisateur:number,
    importanceTypeUtilisateur:number,
    loginUtilisateur:string,
    motdePasseUtilisateur:string,
    nomUtilisateur:string,
    portableUtilisateur:string,
    prenomUtilisateur:string,
    priorite:string,
    statutUtilisateur:string,
    telephoneUtilisateur:string,
    typeUtilisateur:string
   // __proto__:object,
}
interface ObjectResult_Liste_Utilisateur {
    description: string;
    errorCode: string;
    result: Liste_Utilisateur[];
}
interface ObjectResult_LU {
    description: string;
    errorCode: string;
    result: Liste_Utilisateur;
}