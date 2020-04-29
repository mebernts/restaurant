<template>
  <div class="about">
    <v-row>

      
      <v-col cols="12" sm="6" lg="4">
        <h1 id="headline" class="white--text  text-center">About</h1>

      <v-img class="imgFluid" src="@/assets/images/restaurant.jpg"
      width="1000px"
      height="600px">
      </v-img>
      </v-col>
      <v-col cols="12" sm="6" lg="4">

  <p id="about" >
    Autentisk italiensk mat i moderne omgivelser, service og personale 
    som skinner av fellesskap og lidenskap samt dyktige og lekne kokker 
    – akkurat som i en italiensk familie.
    
    Italia åpnet for første gang dørene på Aker Brygge i 2006 med en meny 
    som senere har blitt kjernen i alle Italia-restaurantene; steinovnsbakt, 
    tynn pizza, klassiske pastaretter, antipasti, salater, supper, kjøtt og ikoniske desserter. 
    Det italienske kjøkken verdsetter få, men veldig gode råvarer og dette har vi selvfølgelig adoptert.
  </p>
  </v-col>
  </v-row>
  
  </div>

</template>

<script>
export default {
  
}

</script>

<style scoped>
#about{
  font-family: 'Comic Neue', cursive;
  padding: 50px;
  font-size: 19px;
}

#headline {
  font-family:Georgia, 'Times New Roman', Times, serif;
  background-color:darkslategray;
}
</style>