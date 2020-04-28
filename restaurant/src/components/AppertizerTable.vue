<template>
  <div>
    <v-row>
      <v-col cols="12">
        <v-data-table dense :headers="headers" :items="dishes" :page.sync="page" :items-per-page="itemsPerPage"
      hide-default-footer @page-count="pageCount = $event" class="elevation-1">
            <template v-slot:top>
            <v-toolbar flat>
              <v-toolbar-title vertical>Appertizers</v-toolbar-title>
            </v-toolbar>
          </template>
          <template v-slot:item.actions="{ item }">
            <v-btn small class="mr-2 mb-2" @click="editItem(item)">Edit</v-btn>
            <v-btn small class="mr-2 mb-2" @click="deleteItem(item)">Delete</v-btn>
            <EditFormDialog :dialog2.sync="dialog2" :editId.sync="editId" :editTable.sync="editTable"/>
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
  name: "AppertizerTable",
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
        { text: "Appertizers", value: "name" },
        { text: "Description", value: "description" },
        { text: "Allergies", value: "allergies" },
        { text: "Price (KR)", value: "price" },
        { text: "ImageSrc", value: "imageSrc" },
        { text: "Category", value: "category", width: "150px" },
        { text: "Actions", value: "actions", sortable: false, width: "200px" }
      ],
      dishes: []
    };
  },
  components: {
    EditFormDialog
  },
  created() {
    axios.get("https://localhost:5001/resturant/appertizer").then(result => {
      //console.log(result.data);
      this.dishes = result.data;
    }); // axios that gets information from the database
  },
  methods: {
    deleteItem(item) {
      confirm("Do you want to delete: Id" + item.id + " " + item.name + "?");
      axios
        .delete(`https://localhost:5001/resturant/deleteAppertizer/${item.id}`)
        .then(result => {
          this.deleteStatus = JSON.stringify(result.data);
        })
        .catch(error => {
          console.log(error);
        });
    },
    editItem(item){  
      this.editId = item.id 
      this.editTable = "Appertizer"
      this.dialog2=true
    }
  }
};
</script>

<style>
</style>