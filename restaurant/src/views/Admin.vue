<template>
  <div>
    <h1>This is the Admin Page, Only testing so far</h1>
    <DishForm />
  </div>
</template>

<script>
import DishForm from "../components/DishForm.vue";
export default {
  name: "Admin",
  components: { DishForm }
};
</script>