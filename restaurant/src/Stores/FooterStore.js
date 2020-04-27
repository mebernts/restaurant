const FooterStore = {
    state: {
        footerinfo:[
           {id: 100, contact:"Kontakt info:"},
           {id:101, adress: "Adresse: Oslogate 30", telefon: "Telefon: 20201020", mail:" Mail: italia@email.com"},
           {id: 102, åpningstider: "Åpningstider:"},
           {id: 103, monday: "Mandag: Åpen fra 14", tuesdaySaturday: "Tirsdag-Lørdag: Åpen fra 12", sunday: "Søndag: Stengt"}
        ]
    },
    getFooterinfo(){
        return this.state.footerinfo.map(footer => footer);
    },
}

export default FooterStore;