<template>
  <div>
    <v-row>
      <v-col cols="12">
        <v-data-table
          dense
          :headers="headers"
          :items="dishes"
          :page.sync="page"
          :items-per-page="itemsPerPage"
          hide-default-footer
          @page-count="pageCount = $event"
          class="elevation-1"
        >
          <template v-slot:top>
            <v-toolbar class="blue-grey darken-1 white--text" flat>
              <v-toolbar-title vertical>Drinks</v-toolbar-title>
            </v-toolbar>
          </template>
          <template v-slot:item.actions="{ item }">
            <v-btn
              small
              class="mr-2 mb-1 mt-1 blue-grey darken-1 white--text"
              @click="editItem(item)"
            >Edit</v-btn>
            <v-btn
              small
              class="mr-2 mb-1 mt-1 blue-grey darken-1 white--text"
              @click="deleteItem(item)"
            >Delete</v-btn>
            <EditFormDialog
              :dialog2.sync="dialog2"
              :editId.sync="editId"
              :editTable.sync="editTable"
            />
          </template>
        </v-data-table>
        <v-pagination v-model="page" :length="pageCount"></v-pagination>
      </v-col>
    </v-row>
  </div>
</template>

<script>
import axios from "axios";
import EditFormDialog from "@/components/EditFormDialog.vue";
export default {
  name: "DrinkTable",
  data() {
    return {
      page: 1,
      pageCount: 0,
      itemsPerPage: 10,
      dialog2: false,
      headers: [
        {
          text: "Id",
          align: "start",
          value: "id"
        },
        { text: "Drinks", value: "name" },
        { text: "Price (KR)", value: "price" },
        { text: "Category", value: "category" },
        { text: "Actions", value: "actions", sortable: false }
      ],
      dishes: [],
      editId: 0,
      editTable: ""
    };
  },
  components: {
    EditFormDialog
  },
  created() {
    axios.get("https://localhost:5001/resturant/drinks").then(result => {
      //console.log(result.data);
      this.dishes = result.data;
    }); // axios that gets information from the database
  },
  methods: {
    deleteItem(item) {
      alert("Id:" + item.id + " " + item.name + " Has been deleted");
      axios
        .delete(`https://localhost:5001/resturant/deleteDrink/${item.id}`)
        .then(result => {
          this.deleteStatus = JSON.stringify(result.data);
        })
        .catch(error => {
          console.log(error);
        });
    },
    editItem(item) {
      this.editId = item.id;
      this.editTable = "Drinks";
      this.dialog2 = true;
    }
  }
};
</script>

<style>
</style>