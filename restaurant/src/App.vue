<template>
<v-app>
  <link href="https://fonts.googleapis.com/css2?family=Comic+Neue:ital,wght@0,300;0,700;1,700&family=Dancing+Script&display=swap" rel="stylesheet">
  <div id="app">
    <TheNavigation/>
    <v-content>
      <v-container>
        <keep-alive>
        <router-view/>
        </keep-alive>
        </v-container>
    </v-content>
    <TheFooter/>
  </div>
  </v-app>
</template>
<script>
import TheNavigation from './layout/TheNavigation.vue'
import TheFooter from './layout/TheFooter.vue'
export default {
   name: 'App',
    components: {
      TheNavigation,
      TheFooter
    } 
}
</script>