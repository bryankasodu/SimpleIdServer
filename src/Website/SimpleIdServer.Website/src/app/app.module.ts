import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatFormFieldModule } from '@angular/material/form-field';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { OAuthModule } from 'angular-oauth2-oidc';
import { AppComponent } from './app.component';
import { routes } from './app.routes';
import { HomeModule } from './home/home.module';
import { MaterialModule } from './shared/material.module';
import { SharedModule } from './shared/shared.module';
import { environment } from '../environments/environment';
import { StoreModule } from '@ngrx/store';
import { oauthScopeReducer } from './stores/scopes/oauth/reducers/index';
import { oauthClientReducer } from './stores/clients/oauth/reducers/index';
import { OAuthClientEffects } from './stores/clients/oauth/effects/client.effects';
import { OAuthScopeEffects } from './stores/scopes/oauth/effects/scope.effects';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { EffectsModule } from '@ngrx/effects';
import { OAuthClientService } from './stores/clients/oauth/services/client.service';
import { OAuthScopeService } from './stores/scopes/oauth/services/scope.service'; 
import { appReducer } from './stores/appstate';

export function createTranslateLoader(http: HttpClient) {
    let url = environment.baseUrl + 'assets/i18n/';
    return new TranslateHttpLoader(http, url, '.json');
}

@NgModule({
    imports: [
        RouterModule.forRoot(routes),
        SharedModule,
        MaterialModule,
        HomeModule,
        MatFormFieldModule,
        FlexLayoutModule,
        BrowserAnimationsModule,
        HttpClientModule,
        OAuthModule.forRoot(),
        EffectsModule.forRoot( [ OAuthClientEffects, OAuthScopeEffects ] ),
        StoreModule.forRoot(appReducer),
        StoreDevtoolsModule.instrument({
            maxAge: 10
        }),
        TranslateModule.forRoot({
            loader: {
                provide: TranslateLoader,
                useFactory: (createTranslateLoader),
                deps: [HttpClient]
            }
        })
    ],
    declarations: [
        AppComponent
    ],
    providers: [ OAuthClientService, OAuthScopeService ],
    bootstrap: [AppComponent]
})
export class AppModule { }