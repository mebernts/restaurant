<template>
<div>
  <v-row>
    <v-col>
  <v-img class="imgFluid" src="@/assets/images/header.jpg"
  width="100%"
  height="600px">
   <h1 class="white--text  text-center">Velkommen</h1>
  </v-img>
  </v-col>

  <v-col cols="12" sm="6" lg="4">

  <v-img class="imgFluid" src="@/assets/images/meny.jpg"
  width="500px"
  height="350px">
   <v-btn class="black--text  text-center" to="/menu">Se meny her</v-btn>
  </v-img>
  </v-col>

   <v-col cols="12" sm="6" lg="4">
  <v-img class="imgFluid" src="@/assets/images/matbilde.jpg"
  width="500px"
  height="350px">
  </v-img>
  </v-col>
  <v-col cols="12" sm="6" lg="4">
   <v-img class="align-items imgFluid" src="@/assets/images/about.jpg"
  width="500px"
  height="350px">
   <v-btn class="black--text  text-center" to="/about">Les om oss</v-btn>
  </v-img>
  </v-col>


  </v-row>
  

</div>


</template>

<script>
export default {
  name: "Home"
};
</script>