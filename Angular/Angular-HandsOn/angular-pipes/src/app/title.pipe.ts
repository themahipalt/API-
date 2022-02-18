import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'title'
})
export class TitlePipe implements PipeTransform {

  // transform(value: string): string {
  //   return 'Welcome '+value.toUpperCase();
  // }
  transform(value: string,gender:string): string {
    if(gender=='Male')
    return 'Mr. '+value.toUpperCase();
    else
    return 'Miss. '+value.toUpperCase();
  }
  

}
