<template>
  <v-footer 
  id="footer"
  color="blue-grey darken-3"
  padless
  height="100px">
          <h3 class="white--text">Italia</h3>
          <v-spacer></v-spacer>
        <ul class="white--text">
            <li class="text-center" v-for="footer in footerinfo" :key="footer.id">
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
        <v-spacer></v-spacer>
        <v-row>
        <v-col>
        <h3 class="white--text">Sosiale medier</h3>
        <v-icon size="30px" color="white">mdi-facebook</v-icon>
        <v-icon size="30px" class= "icon" color="white">mdi-instagram</v-icon>
        <v-icon size="30px" color="white">mdi-twitter</v-icon>
        </v-col>
        </v-row>
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
.italy{
    font-family: 'Dancing Script', cursive;
}
#footer ul{
    list-style: none;

}
</style>