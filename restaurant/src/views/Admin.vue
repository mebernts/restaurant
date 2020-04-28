<template>
  <div>
    <v-row>
      <v-container cols="12">
        <v-col cols="12" class="mx-auto">
          <v-toolbar>
            <v-toolbar-title>Admin</v-toolbar-title>
          </v-toolbar>
          <v-col cols="12" md="8">
            <v-btn class="mr-2" @click="component='AppertizerTable'">Appertizers</v-btn>
            <v-btn class="mr-2" @click="component='DishTable'">Main Dishes</v-btn>
            <v-btn class="mr-2" @click="component='DrinkTable'">Drinks</v-btn>
            <v-btn class="mr-2 primary Dark" @click="dialog=true">Add new Dish</v-btn>
            <v-btn @click="reRender">
              <v-icon>mdi-refresh</v-icon>
            </v-btn>
            <DishFormDialog :dialog.sync="dialog" />
          </v-col>
        </v-col>
        <v-col cols="12" class="mx-auto" >
          <component v-bind:is="component"  :key="componentKey"></component>
        </v-col>
      </v-container>
    </v-row>
  </div>
</template>

<script>
import DishFormDialog from "../components/DishFormDialog.vue";
import DishTable from "../components/DishTable.vue";
import AppertizerTable from "@/components/AppertizerTable.vue";
import DrinkTable from "@/components/DrinkTable.vue";
export default {
  name: "Admin",
  data() {
    return {
      dialog: false,
      component: "DishTable",
      componentKey: 0
    };
  },
  watch: {
    dialog(val) {
      val || this.close();
    },
    dialog2(val) {
      val || this.close();
    }
  },
  components: { DishFormDialog, DishTable, AppertizerTable, DrinkTable },
  methods: {
    reRender() {
      this.componentKey += 1;
    }
  }
};
</script>