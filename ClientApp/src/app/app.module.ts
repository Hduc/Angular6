import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';

import { CollapseModule } from 'ngx-bootstrap/collapse';
import { NgxPaginationModule } from 'ngx-pagination'; // install pagination:  npm install ngx-pagination --save

import { NgxMasonryModule } from 'ngx-masonry';//npm install ngx-masonry --save
import { NgxCarouselModule } from 'ngx-carousel'; //npm install ngx-carousel --save

import { SweetAlert2Module } from '@toverux/ngx-sweetalert2';
import 'hammerjs';//npm install hammerjs --save
import { DataTableModule } from "angular-6-datatable";//npm install angular-6-datatable --save
import { NgSelectModule, NG_SELECT_DEFAULT_CONFIG } from '@ng-select/ng-select';//npm install --save @ng-select/ng-select
import { DragDropModule } from '@angular/cdk/drag-drop'; //npm install @angular/cdk@7.0.3

import { LayoutIndexComponent } from './_Layout/layout-index/layout-index.component';
import { LayoutComponent } from './_Layout/layout/layout.component';

import { AdminAccountComponent } from './Page/admin-account/admin-account.component';
import { AdminIndexComponent } from './Page/admin-index/admin-index.component';
import { JourComponent } from './Page/jour/jour.component';
import { AtelierComponent } from './Page/atelier/atelier.component';
import { VosRendezVousDetailComponent } from './Page/vos-rendez-vous-detail/vos-rendez-vous-detail.component';
import { VosRendezVousComponent } from './Page/vos-rendez-vous/vos-rendez-vous.component';
import { LoginComponent } from './Page/login/login.component';
import { SocialMediaComponent } from './Page/social-media/social-media.component';
import { ParticipantsComponent } from './Page/participants/participants.component';
import { EventComponent } from './Page/event/event.component';
import { DetailEventComponent } from './Page/detail-event/detail-event.component';
import { VosInformationComponent } from './Page/vos-information/vos-information.component';
import { NotfoundComponent } from './Page/notfound/notfound.component';
import { VotreContactComponent } from './Page/votre-contact/votre-contact.component';
import { ParametresComponent } from './Page/parametres/parametres.component';
import { PubComponent } from './Page/pub/pub.component';

import { LogoComponent } from './Component/logo/logo.component';
import { SearchComponent } from './Component/search/search.component';
import { InfoComponent } from './Component/info/info.component';
import { BannerComponent } from './Component/banner/banner.component';
import { SliderlogoComponent } from './Component/sliderlogo/sliderlogo.component';
import { MenuItemComponent } from './Component/menu-item/menu-item.component';
import { AddparticipantComponent } from './Page/participants/addparticipant/addparticipant.component';
import { UpdateparticipantComponent } from './Page/participants/updateparticipant/updateparticipant.component';

import { ContactService } from './services/contact.service';
import { UploadService } from './services/upload.service';
import { QuestionService } from './services/question.service';
import { HttpErrorHandler } from './http-error-handler.service';
import { MessageService } from './message.service';
import { EventService } from './services/event.service';


@NgModule({
  declarations: [
    AppComponent,
    BannerComponent,
    LayoutComponent,
    LoginComponent,
    MenuItemComponent,
    SocialMediaComponent,
    ParticipantsComponent,
    EventComponent,
    DetailEventComponent,
    VosInformationComponent,
    VosRendezVousComponent,
    VosRendezVousDetailComponent,
    AtelierComponent,
    JourComponent,
    AdminIndexComponent,
    AdminAccountComponent,
    SliderlogoComponent,
    LogoComponent,
    SearchComponent,
    InfoComponent,
    LayoutIndexComponent,
    NotfoundComponent,
    VotreContactComponent,
    AddparticipantComponent,
    UpdateparticipantComponent,
    ParametresComponent,
    PubComponent
  ],

  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    DataTableModule,
    NgxPaginationModule,
    NgxMasonryModule,
    CollapseModule.forRoot(),
    SweetAlert2Module.forRoot(),
    [SweetAlert2Module],
    NgxCarouselModule,
    NgSelectModule, 
    DragDropModule,
    SweetAlert2Module.forRoot({
      buttonsStyling: false,
      customClass: 'modal-content',
      confirmButtonClass: 'btn btn-primary',
      cancelButtonClass: 'btn'
    }),

    RouterModule.forRoot([
      { path: '', redirectTo: 'login', pathMatch: 'full' },
      { path: 'login', component: LoginComponent },
      {
        path: '', component: LayoutComponent, children: [
          { path: 'social-media/:id', component: SocialMediaComponent },
          { path: 'participants/:id', component: ParticipantsComponent },
          { path: 'information/:id', component: VosInformationComponent },
          { path: 'speed-meetings/:id', component: VosRendezVousComponent },
          { path: 'speed-meetings-detail/:id', component: VosRendezVousDetailComponent },
          { path: 'atelier/:id', component: AtelierComponent },
          { path: 'votre-contact/:id', component: VotreContactComponent },
          { path: 'practique/:id', component: JourComponent },
          { path: 'pub/:id', component: PubComponent },
          { path: 'notfound', component: NotfoundComponent }
        ]
      },
      {
        path: '', component: LayoutIndexComponent, children: [
          { path: 'event/:id', component: EventComponent },
          { path: 'event-detail/:id', component: DetailEventComponent },
          { path: 'admin/:id', component: AdminIndexComponent },
          { path: 'admin-account/:id', component: AdminAccountComponent },
          { path: 'parametres/:id', component: ParametresComponent },

          { path: '**', component: NotfoundComponent },
        ]
      },
    ])
  ],
  providers: [
    HttpErrorHandler,
    MessageService,
    ContactService,
    QuestionService,
    UploadService,
    EventService,
    {
      provide: NG_SELECT_DEFAULT_CONFIG,
      useValue: {
          notFoundText: 'Custom not found'
      }
  }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
