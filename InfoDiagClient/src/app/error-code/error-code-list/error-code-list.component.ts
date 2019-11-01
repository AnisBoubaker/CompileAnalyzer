import { Component, OnInit, ViewChild } from '@angular/core';
import { ErrorCodeService } from 'src/app/services/error-code.service';
import { ErrorCode } from 'src/app/generic/models/errorCode';
import { ToastrService } from 'ngx-toastr';
import { MatTableDataSource, MatPaginator } from '@angular/material';

@Component({
  selector: 'app-error-code-list',
  templateUrl: './error-code-list.component.html',
  styleUrls: ['./error-code-list.component.css']
})
export class ErrorCodeListComponent implements OnInit {
  loaded = false;
  errorCodes: MatTableDataSource<ErrorCode>;
  displayedColumns: string[] = ['id', 'name', 'description', 'link'];
  base: ErrorCode[];
  searchbar = '';
  searchLoading = false;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;

  constructor(
    private errorCodeService: ErrorCodeService,
    private toastrService: ToastrService
  ) {}

  ngOnInit() {
    this.initErrorCodes();
  }

  seed() {
    this.errorCodeService.seed().subscribe(() => {
      this.toastrService.success(
        "Les codes d'erreur ont été chargés",
        'Succès'
      );
      this.initErrorCodes();
    });
  }

  initErrorCodes() {
    this.loaded = false;
    this.errorCodeService.getErrorCodes().subscribe(ec => {
      this.base = ec;
      this.errorCodes = new MatTableDataSource<ErrorCode>(ec);
      this.errorCodes.paginator = this.paginator;
      this.loaded = true;
    });
  }

  searchChange() {
    this.searchLoading = true;
    const value: string = this.searchbar.toUpperCase();
    if (value && value.length > 2) {
      this.errorCodes.data = this.base.filter(
        ec =>
          ec.id.toUpperCase().includes(this.searchbar) ||
          ec.name.toUpperCase().includes(this.searchbar) ||
          ec.description.toUpperCase().includes(this.searchbar)
      );
    } else {
      this.errorCodes.data = this.base;
    }
    this.searchLoading = false;
  }

  goto(link: string) {
    window.open(link, '_blank');
  }
}
