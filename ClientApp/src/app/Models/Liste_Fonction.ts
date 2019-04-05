interface Liste_Fonction {
    idTypeFonction :number,
    typeFonction: string,
    idListeFonction: number,
    fonctionGenerique: string,
    importanceListeFonction: number,
    fonctionGeneriqueAbrege: string
}
interface Object_ListeFonction {
    description: string;
    errorCode: string;
    result: Liste_Fonction[];
}