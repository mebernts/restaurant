<template>
  <v-footer 
  id="footer"
  color="blue-grey darken-3">
  <v-card
  class="flex"
  flat>
      <v-card-title 
      id="italy" 
      class="blue-grey darken-3 white--text justify-center">Italia</v-card-title>
      <v-card-text 
      class="blue-grey darken-3">
          <ul>
          <li class="text-center white--text" v-for="footer in footerinfo" :key="footer.id">
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
      </v-card-text>
      <v-divider></v-divider>
      <v-card-text 
      class="text-center blue-grey darken-3">
      <v-icon size="30px" color= "light-blue lighten-3">mdi-facebook</v-icon>
      <v-icon size="30px" color="light-blue lighten-3">mdi-instagram</v-icon>
      <v-icon size="30px" color="light-blue lighten-3">mdi-twitter</v-icon>
      </v-card-text>

  </v-card>
    
    </v-footer>
</template>

<script>
import FooterStore from '@/Stores/FooterStore.js'
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
#italy{
    font-family: 'Dancing Script', cursive;
    font-size: 1.5rem;
}
#footer ul{
    list-style: none;

}
</style>