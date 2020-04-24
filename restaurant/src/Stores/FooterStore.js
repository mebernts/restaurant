const FooterStore = {
    state: {
        footerinfo:[
           {id:100, adress: "Oslogate 30", telfon: 20201020}

        ]
    },
    getFooterinfo(){
        return this.state.footerinfo.map(footer => footer);
    }
}

export default FooterStore;