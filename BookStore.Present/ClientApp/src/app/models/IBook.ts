import { Byte } from "@angular/compiler/src/util";
import { IAuthor } from "./IAuthor";

export interface IBook {
  Id:number,
  Title:string,
  DateOfPublication:Date,
  Cover:Byte,
  Description:string,
  Authors:Array<IAuthor>
}
