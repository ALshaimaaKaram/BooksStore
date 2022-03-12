import { Byte } from "@angular/compiler/src/util";
import { IAuthor } from "./IAuthor";

export interface IBook {
  id:number,
  title:string,
  dateOfPublication:Date,
  cover:Byte,
  description:string,
  authors:Array<IAuthor>
}
