<template>
  <div>
    <v-row>
      <v-col>
        <v-img class="imgFluid" src="@/assets/images/header.jpg" width="100%" height="600px">
          <v-container fill-height>
            <v-layout row wrap align-center>
              <v-flex class="text-center">
                <span class="display-3 font-weight-medium white--text">Velkommen</span>
              </v-flex>
            </v-layout>
          </v-container>
        </v-img>
      </v-col>

      <v-col cols="12" sm="6" lg="4">
        <v-img class="imgFluid" src="@/assets/images/meny.jpg" width="500px" height="350px">
        <v-container fill-height>
            <v-layout row wrap align-center>
              <v-flex class="text-center">
                <v-btn class="white--text blue-grey darken-2 text-center font-weight-bold elevation-10" x-large to="/menu" >Se meny her</v-btn>
              </v-flex>
            </v-layout>
          </v-container>  
        </v-img>
      </v-col>

      <v-col cols="12" sm="6" lg="4">
        <v-img class="imgFluid" src="@/assets/images/matbilde.jpg" width="500px" height="350px"></v-img>
      </v-col>
      <v-col cols="12" sm="6" lg="4">
        <v-img
          class="align-items imgFluid"
          src="@/assets/images/about.jpg"
          width="500px"
          height="350px"
        >
        <v-container fill-height>
            <v-layout row wrap align-center>
              <v-flex class="text-center">
                <v-btn class="white--text blue-grey darken-2 text-center font-weight-bold elevation-10" x-large to="/about">Les om oss</v-btn>
              </v-flex>
            </v-layout>
          </v-container>
          
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