import { WithId } from "../../shared/interfces/withId.interface";

export class Model implements WithId {
    constructor(public Id: number, private Name: string, private Date: Date, private Make: any) {
            
    }
}
