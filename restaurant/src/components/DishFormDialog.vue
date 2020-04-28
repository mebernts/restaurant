<template>
  <v-row>
    <v-dialog v-model="dialog" persistent max-width="600px">
      <v-card justify="center">
        <v-card-title>
          <span>New Dish</span>
        </v-card-title>
        <v-card-text>
          <v-container>
            <v-row>
              <v-col cols="12">
                <v-select v-model="dishCategorySelected" :items="dishCategory" label="Table"></v-select>
              </v-col>
              <v-col cols="12" md="6">
                <v-text-field v-model="newDish.name" label="Name"></v-text-field>
              </v-col>
              <v-col cols="12" md="6">
                <v-select v-model="newDish.category" :items="categoryList" label="Category" ></v-select>
              </v-col>
              <v-col cols="12">
                <v-textarea v-model="newDish.description" label="Description" auto-grow></v-textarea>
              </v-col>
              <v-col cols="12" md="6">
                <v-text-field v-model.number="newDish.price" label="Price" prefix="kr"></v-text-field>
              </v-col>
              <v-col cols="12" md="6">
                <v-text-field v-model="newDish.allergies" label="Allergies"></v-text-field>
              </v-col>
              <v-col cols="12">
                <v-file-input v-model="file" show-size></v-file-input>
              </v-col>
            </v-row>
          </v-container>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn @click="close">Cancel</v-btn>
          <v-btn @click="postDish">Save</v-btn>
          <!--Endre click event til post-->
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-row>
</template>

<script>
import axios from "axios";
export default {
  name: "DishFormDialog",
  data() {
    return {
      newDish: {
        name: "",
        description: "",
        allergies: "",
        price: "",
        imageSrc: "",
        category: ""
      },
      file: null,
      dishCategorySelected: "",
      dishCategory: ["Appertizer", "Dishes", "Drinks"],
      categoryList: [
        "Antipasti",
        "Pizza Rossa",
        "Pizza Bianche",
        "la Pasta",
        "Brus",
        "Mineralvann",
        "Te",
        "Kaffe"
      ]
    };
  },
  props: {
    dialog: {
      default: false
    }
  },
  methods: {
    close() {
      this.$emit("update:dialog", false);
    },
    postDish() {
      if (this.dishCategorySelected == "Dishes") {
        if (this.file === null) {
          this.newDish.imageSrc = null;

          axios
            .post("https://localhost:5001/resturant/PostDish", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);
            })

            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.newDish.imageSrc = this.file.name;

          axios
            .post("https://localhost:5001/Resturant/Postdish", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);

              axios({
                method: "POST",
                url: "https://localhost:5001/resturantadmin/uploadimage",
                data: data,
                config: { headers: { "Content-Type": "multipart/form-data" } }
              });
            })
            .catch(error => {
              console.log(error);
            });
        }
      } else if (this.dishCategorySelected === "Drinks") {
        if (this.file === null) {
          this.newDish.imageSrc = null;

          axios
            .post("https://localhost:5001/resturant/postdrink", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);
            })

            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.newDish.imageSrc = this.file.name;

          axios
            .post("https://localhost:5001/Resturant/postdrink", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);

              axios({
                method: "POST",
                url: "https://localhost:5001/resturantadmin/uploadimage",
                data: data,
                config: { headers: { "Content-Type": "multipart/form-data" } }
              });
            })
            .catch(error => {
              console.log(error);
            });
        }
      } else if (this.dishCategorySelected === "Appertizer") {
        if (this.file === null) {
          this.newDish.imageSrc = null;

          axios
            .post(
              "https://localhost:5001/resturant/postappertizer",
              this.newDish
            )
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);
            })

            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.newDish.imageSrc = this.file.name;

          axios
            .post(
              "https://localhost:5001/Resturant/postappertizer",
              this.newDish
            )
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);

              axios({
                method: "POST",
                url: "https://localhost:5001/resturantadmin/uploadimage",
                data: data,
                config: { headers: { "Content-Type": "multipart/form-data" } }
              });
            })
            .catch(error => {
              console.log(error);
            });
        }
      }
      alert("A new Dish has been added!")
      this.$emit("update:dialog", false);

      // base til hvordan det fungerer
    }
  }
};
</script>