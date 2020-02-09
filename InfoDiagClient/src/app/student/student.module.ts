import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { StudentComponent } from "./student.component";
import { StatsModule } from "../stats/stats.module";
import { StudentListComponent } from "./student-list/student-list.component";
import { MatButtonModule } from "@angular/material/button";
import { MatIconModule } from "@angular/material/icon";
import { MatPaginatorModule } from "@angular/material/paginator";
import { MatTableModule } from "@angular/material/table";
import { StudentService } from "../services/student.service";

@NgModule({
  declarations: [StudentComponent, StudentListComponent],
  imports: [
    CommonModule,
    MatTableModule,
    MatIconModule,
    MatButtonModule,
    MatPaginatorModule,
    StatsModule
  ],
  providers: [StudentService]
})
export class StudentModule {}
