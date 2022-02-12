import { NgModule } from '@angular/core';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatDividerModule} from '@angular/material/divider';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import {MatCardModule} from '@angular/material/card';
const MaterialModuels:any=[
MatButtonModule,
MatIconModule,
MatDividerModule,
MatButtonToggleModule,
MatCardModule
]
@NgModule({
 
  imports: [MaterialModuels],
  exports:[MaterialModuels]
})
export class MaterialModule { }
