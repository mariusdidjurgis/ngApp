import { WithId } from "../../shared/interfces/withId.interface";

export class Make implements WithId {
    constructor(public Id: number, private Name: string, private Date: Date, private HeadQuatersLocation: string){
            
    }
}
