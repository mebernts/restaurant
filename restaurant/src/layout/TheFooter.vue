<template>
  <v-footer id="footer" class="blue-grey darken-3">
        <h3 class="footerText">Footer</h3>
        <ul>
            <li v-for="footer in footerinfo" :key="footer.id">
                {{footer.contact}}
                {{footer.adress}}
                {{footer.telefon}}
                {{footer.mail}}
                {{footer.åpningstider}}
                {{footer.monday}}
                {{footer.tuesdaySaturday}}
                {{footer.sunday}}
            </li>
        </ul>

        <v-icon color="white">mdi-facebook</v-icon>
        <v-icon color="white">mdi-instagram</v-icon>
        <v-icon color="white">mdi-twitter</v-icon>
        
    </v-footer>
</template>

<script>
import FooterStore from '@/stores/FooterStore.js'
export default {
    name: "TheFooter",
    data(){
        return{
            footerinfo: FooterStore.getFooterinfo()
        }
    }
}
</script>

<style scoped>
.footerText{
    color: white;
}

#footer{
    height: 100px;
}
</style>