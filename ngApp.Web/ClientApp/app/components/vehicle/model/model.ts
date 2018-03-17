import { WithId } from "../../shared/interfces/withId.interface";

export class Model implements WithId {
    constructor(public Id: number, private Name: string, private ColorId: number, private MakeId: number) {
            
    }
}
