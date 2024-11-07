# ARZsw - Service-DLL - Versionen

|Version|Datum|Beschreibung und Änderungen|
|---:|:---:|---|
|V0.1.2.**1**|23.07.2024|**Aktualisierung der Bouncy Castle Crypto Library von 1.9.0 auf 2.4**<br> - Umstellung von manueller DLL auf NuGet-Paket<br> - Anpassen bzw. Überarbeiten der Methoden die Bouncy Castel nutzen (Signaturprüfung)<br>**Test-Client** ergänzt<br>- Prüfungen zur neuen Bouncy Castle Crypto Library ergänzt|
|V0.1.**2**.0|27.06.2024|**Aktualisierung der FHIR Ressourcen (NuGet-Pakete) von 3.8.0 auf 5.8.1**<br> - inkl. Bereinigung der Abhängigkeiten<br>**Quittung** neu implementiert<br>- Modell und Verarbeitung der Quittung erstmalig implementiert|
||||
|V0.1.1.**8**|15.05.2024|**Fehlerbehebung** - `eAbrechnungsdaten`<br> - Eintrag der Rabatte bei den Zusatzdaten Herstellung fehlerhaft<br>-> Fehlerkorrekturen bei der TA7 Erstellung der Zu- und Abschläge<br>- Auslesen der alternativen Kostenträger-IK fehlerhaft|
|V0.1.1.**7**|19.02.2024|**eRezeptModelle** - `ModellApoTiRezeptStatusInfo`<br>- Attribut `fHauptfehler` (`bool`) ergänzt<br>**eAbrechnungsdaten** - `ModellTA7RechnungBundle` Attribut Dateinamen als Liste hinzugefügt<br> - Eine TA7 Datenlieferung kann aus mehreren TA7-Dateien bestehen<br>**Fehlerbehebung** - `eAbrechnungsdaten`<br> - Eintrag der Rabatte bei den Zusatzdaten Herstellung fehlerhaft<br> -> Zu- und Abschläge werden nicht ausgegeben|
|V0.1.1.**6**|11.12.2023|**eAbrechnungsdaten** - Erstellen der TA7 für mehr als 1.500 E-Rezepte (große TA7)<br> - Methode `GetEAbrechnungsdatenOhneRezepte()` erstellt das TA7 Bundle ohne die E-Rezept Bundles<br> - Methode `GetEAbrechnungsdatenRezept()` erstellt E-Rezept Bundle für die TA7<br> -> Das erstellte E-Rezept Bundle kann dann an die TA7 ohne E-Rezepte angehangen werden|
|V0.1.1.**5**|30.11.2023|**eAbgabedaten** - Zweite URL beim Auslesen der Hersteller-IK in `ZusatzdatenHerstellungen` hinzugefügt<br> - FixedValue `MEDICATIONDISPENSE_ZUSATZDATEN_PERFORMER_ACTOR_IDENTIFIER_SYSTEM_2`|
|V0.1.1.**4**|21.11.2023|Beim Aktualisieren von Prüfungsergebnissen `SetERezeptFehlerStatus()` wird auch eine neu UUID geschrieben und das Flag Transfer_ARZ zurückgesetzt|
|V0.1.1.**3**|04.09.2023|Fehlerbehebung der TA7 FHIR-Profile V1.3 Implementierung|
|V0.1.1.**2**|31.07.2023|Fehlerbehebung der TA7 FHIR-Profile V1.3 Implementierung|
|V0.1.1.**1**|13.07.2023|Verarbeitung des TA7 FHIR-Profile V1.3 implementiert|
|V0.1.**1**.0|01.07.2023|Erste Version zur Verarbeitung der FHIR-Profile ab 01.07.2023<br> => **Modelle und Methoden mit Änderungen der FHIR-Profile werden dupliziert und mit dem Zusatz \_JJMM [für 01. Juli 2023 - \_2307] versehen**<br> - FixedValues `const` in `string` geändert<br> - `switch..case` in `if..else` geändert - aufgrund der FixedValue Änderung|
||||
|V0.1.0.**17**|bis 30.06.2023|Letzte Version zur Verarbeitung der FHIR-Profile bis 30.06.2023|


