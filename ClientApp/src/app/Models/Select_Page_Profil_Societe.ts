interface Liste_Pays {
    idListePays: number,
    pays: string,
    parDefaut: boolean,
    indicatif: string,
    abreviationPays: string
}
interface ObjectResult_Liste_Pays {
    description: string;
    errorCode: string;
    result: Liste_Pays[];
}

interface TypeEffectif {
    idTypeEffectif: number,
    typeEffectif: string,
    idBiblio_Niv2: number,
    parDefaut: boolean,
    typeEffectifAbrege: string
}
interface ObjectResult_TypeEffectif {
    description: string;
    errorCode: string;
    result: TypeEffectif[];
}

interface CodeApe2008 {
    idape2008: string,
    leftIdape20082: string,
    leftIdape20083: string,
    leftIdape20084: string,
    leftIdape20085: string,
    idniveau: number,
    libelleApe2008: string,
    idlibelleApe2008: string,
    idnomenclatureEquivalente: string,
    libelleApe2008abrege: string,
    codeApe2003pardefaut: string
}
interface ObjectResult_CodeApe2008 {
    description: string;
    errorCode: string;
    result: CodeApe2008[];
}

interface TypeNature {
    idTypeNature: number,
    typeNature: string,
    idBiblio_Niv2: string,
    icoNature: string
}
interface ObjectResult_TypeNature {
    description: string;
    errorCode: string;
    result: TypeNature[];
}

interface FormeJuridique {
    idbiblioNiv3: number,
    idbiblioNiv2: number,
    idstatutBiblioNiv3: number,
    biblioNiv3: string,
    biblioNiv3en: string,
    biblioNiv3de: string,
    biblioNiv3es: string,
    detailBiblio: string,
    ordreNiv3: string,
    parDefaut: boolean,
    oldId: number,
    dictionnaire: boolean,
    autreBiblio: string,
    idnomBiblioNiv3: string,
    idutilisateurBiblioNiv3: number
}
interface ObjectResult_FormeJuridique {
    description: string;
    errorCode: string;
    result: FormeJuridique[];
}
interface TypeCA {
    idTypeCA: number,
    typeCA: string,
    idBiblio_Niv2:number,
    parDefaut: any,
    typeCAAbrege: string
}
interface ObjectResult_TypeCA {
    description: string;
    errorCode: string;
    result: TypeCA[];
}