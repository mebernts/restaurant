<template>
  <article>
    <v-card>
      <v-img :src="`https://localhost:5001/images/${imageSrc}`" height="200px"></v-img>
      <v-card-title>{{name}}</v-card-title>
      <v-card-text>{{description}}</v-card-text>
      <v-card-text>{{allergies}}</v-card-text>
      <v-card-text>
        {{category}}
        <span class="subtitle float-right font-weight-bold">{{price}} Kr</span>
      </v-card-text>
      <v-rating color="amber" background-color="grey darken-1" half-increments size="20"></v-rating>
    </v-card>
  </article>
</template>

<script>
export default {
  props: {
    name: {
      type: String
    },
    description: {
      type: String
    },
    allergies: {
      type: String
    },
    price: {
      type: Number
    },
    imageSrc: {
      type: String
    },
    category: {
      type: String
    }
  }
};
</script>