<template>
<v-app>
  <div id="app">
    <TheNavigation/>
    <router-view/>
  </div>
  </v-app>
</template>
<script>
import TheNavigation from './layout/TheNavigation.vue'
export default {
   name: 'App',
    components: {
      TheNavigation
    } 
}
</script>